using CoreVuePostgreSQL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreVuePostgreSQL.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeDbContext _db;

        public EmployeeService(EmployeeDbContext db)
        {
            _db = db;
        }

        public string AddNewEmployee(EmployeeModel empModel)
        {
            _db.EmployeesMst.Add(empModel);
            _db.SaveChanges();
            return ("Successfully added new employee!");
        }

        public string DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> GetEmployees()
        {
            var empList = _db.EmployeesMst.ToList();
            return empList;
        }

        public string UpdateEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
