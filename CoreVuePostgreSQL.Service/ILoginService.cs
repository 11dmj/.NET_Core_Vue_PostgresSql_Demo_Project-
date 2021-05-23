using System;
using System.Collections.Generic;
using CoreVuePostgreSQL.Data.Models;

namespace CoreVuePostgreSQL.Service
{
    public interface ILoginService
    {
        public EmployeeModel EmployeeLogin();
        public string EmployeeRegistration();
    }
}
