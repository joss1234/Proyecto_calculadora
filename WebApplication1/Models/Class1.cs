using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Class1
    {
        public int n1 { get; set; }
        [Required(ErrorMessage = "El campo {0} requiere ser llenado")]
        public int n2 { get; set; }
        [Required(ErrorMessage = "El campo {0} requiere ser llenado")]
        public int total { get; set; }
    }
}