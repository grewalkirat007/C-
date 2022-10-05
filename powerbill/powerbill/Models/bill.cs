using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace powerbill.Models
{
    public class bill
    {
        [Required(ErrorMessage = "Enter Num")]
        public decimal? total_kilowatt { get; set; }
        [Required(ErrorMessage = "Enter Num")]
        public decimal? hours { get; set; }
        [Required(ErrorMessage = "Enter Num")]
        public decimal? cost { get; set; }
        [Required(ErrorMessage = "Enter Num")]
        public decimal? ans { get; set; }

        public decimal? main()
        {
            ans = total_kilowatt * ( hours * 30 ) * cost;
            return ans;
        }
    }
}
