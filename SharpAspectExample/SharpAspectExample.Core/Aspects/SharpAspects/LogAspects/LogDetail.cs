using System;
using System.Collections.Generic;
using System.Text;

namespace SharpAspectExample.Core.Aspects.SharpAspects.LogAspects
{
    public class LogDetail
    {
        public string FullName { get; set; }
        public string MethodName { get; set; }
        public List<LogParameter> Parameters { get; set; }
    }
}
