using System;
using System.Collections.Generic;
using System.Text;

namespace SharpAspectExample.Core.Aspects.SharpAspects.LogAspects.Models
{
    public class LogErrorDetail:LogDetail
    {
        public string ErrorMessage { get; set; }
    }
}
