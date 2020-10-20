
using SharpAspect;
using SharpAspectExample.Core.Aspects.SharpAspects.LogAspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpAspectExample.Core.Aspects.SharpAspects
{
    [InterceptFor(typeof(LogAttribute))]
    public class LogInterceptor : MethodInterceptor
    {
        private readonly Logger logger;

        // The Logger dependency will be resolved using Microsoft's DI container
        public LogInterceptor(Logger logger)
        {
            this.logger = logger;
        }
        // MethodInterceptor class provides OnBefore, OnAfter and OnError methods.
        // You can override these methods to seperate the logic you don't want in your actual method.
        public override Task OnBefore(IInvocation invocation)
        {
            var logParamters = invocation.MethodInvocationTarget.GetParameters().Select((t, i) => new LogParameter { Name = t.Name, Type = t.ParameterType.Name, Value = invocation.GetArgumentValue(i) }).ToList();

            var date = DateTime.Now;

            var logObj = new LogDetail
            {
                FullName = invocation.TargetType.FullName,
                MethodName = invocation.Method.Name,
                Parameters = logParamters

            };
            logger.LogInfo(logObj);

            return Task.FromResult(Task.CompletedTask);
        }
        public override Task OnError(IInvocation invocation, Exception e)
        {
            var logParamters = invocation.MethodInvocationTarget.GetParameters().Select((t, i) => new LogParameter { Name = t.Name, Type = t.ParameterType.Name, Value = invocation.GetArgumentValue(i) }).ToList();

            var date = DateTime.Now;

            var logObj = new LogDetail
            {
                FullName = invocation.TargetType.FullName,
                MethodName = invocation.Method.Name,
                Parameters = logParamters

            };
            logger.LogInfo(logObj);

            return Task.FromResult(Task.CompletedTask);
        }
    }
}
