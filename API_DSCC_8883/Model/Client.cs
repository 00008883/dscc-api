using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_DSCC_8883.Model
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public int? LoyaltyLevel { get; set; }
        [ForeignKey("LoyaltyLevel")]
        public Loyalty LoyaltyInfo { get; set; }
        public string PostCode { get; set; }
    }
}
