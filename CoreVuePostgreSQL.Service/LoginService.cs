using CoreVuePostgreSQL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreVuePostgreSQL.Service
{
    public class LoginService:ILoginService
    {
        private readonly EmployeeDbContext _db;

        public LoginService(EmployeeDbContext db)
        {
            _db = db;
        }

        public EmployeeModel EmployeeLogin()
        {
            throw new NotImplementedException();
        }

        public string EmployeeRegistration()
        {
            throw new NotImplementedException();
        }
    }
}
