using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Logs.Models
{
    public partial class Log
    {   
        [Key]
        public int IdLog { get; set; }
        public string Description { get; set; }
        public string DateRegister { get; set; }
    }
}
