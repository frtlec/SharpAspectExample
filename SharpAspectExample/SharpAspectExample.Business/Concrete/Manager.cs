
using SharpAspect;
using SharpAspectExample.Business.Abstract;
using SharpAspectExample.Core.Aspects.SharpAspects.LogAspects;
using System;


namespace SharpAspectExample.Business.Concrete
{
    [Intercept(typeof(IService))]
    public class Manager : IService
    {
        [Log]
        public string Test()
        {
            return "test";
        }
    }
}
