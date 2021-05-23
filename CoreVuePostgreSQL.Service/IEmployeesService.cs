using CoreVuePostgreSQL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreVuePostgreSQL.Service
{
    public interface IEmployeeService
    {
        public string AddNewEmployee(EmployeeModel empModel);
        public List<EmployeeModel> GetEmployees();
        public string UpdateEmployee();
        public string DeleteEmployee();
    }
}
