using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_DSCC_8883.Model
{
    public class Loyalty
    {
        [Key]
        public int Level { get; set; }
        public string LoyaltyName { get; set; }
        public double? Percentage { get; set; }
    }
}
