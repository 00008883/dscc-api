using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_DSCC_8883.Model
{
    public class Branch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string BranchCode { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
    }
}
