using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreVuePostgreSQL.Web.RequestModel
{
    public class NewEmployee
    {
        //public int empId { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string psswd { get; set; }
    }
}
