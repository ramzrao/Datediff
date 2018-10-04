using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Datediff.Models
{
    public class DateModel
    {
        [Required]
        [Display(Name = "From Date")]
        [RegularExpression(@"^(?:(?:(?:0[1-9]|[12]\d|3[01])/(?:0[13578]|1[02])|(?:0[1-9]|[12]\d|30)/(?:0[469]|11)|(?:0[1-9]|1\d|2[0-8])/02)/(?!0000)\d{4}|(?:(?:0[1-9]|[12]\d)/02/(?:(?!0000)(?:[02468][048]|[13579][26])00|(?!..00)\d{2}(?:[02468][048]|[13579][26]))))$
", ErrorMessage ="Enter Valid From Date")]
        public string FromDate { get; set; }

        [Required]
        [Display(Name = "To Date")]
        [RegularExpression(@"^(?:(?:(?:0[1-9]|[12]\d|3[01])/(?:0[13578]|1[02])|(?:0[1-9]|[12]\d|30)/(?:0[469]|11)|(?:0[1-9]|1\d|2[0-8])/02)/(?!0000)\d{4}|(?:(?:0[1-9]|[12]\d)/02/(?:(?!0000)(?:[02468][048]|[13579][26])00|(?!..00)\d{2}(?:[02468][048]|[13579][26]))))$
", ErrorMessage = "Enter Valid To Date")]
        public string ToDate { get; set; }


        public string TotalDays { get; set; }
    }
}