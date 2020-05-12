using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportGeneration.Web.Models
{
    public class FailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
