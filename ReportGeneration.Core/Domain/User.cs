using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ReportGeneration.Core.Domain
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
    }
}
