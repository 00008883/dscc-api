using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_DSCC_8883.Model
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string BranchCode { get; set; }
        public string Position { get; set; }
        [ForeignKey("BranchCode")]
        public virtual Branch BranchInfo { get; set; }
    }
}
