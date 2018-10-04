using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Datediff.Models
{
    public class DateViewModel
    {
        [Required]
        [Display(Name = "From Date")]
        public string FromDate { get; set; }

        [Required]
        [Display(Name = "To Date")]
        
        public string ToDate { get; set; }


        public int TotalDays { get; set; }
    }
}