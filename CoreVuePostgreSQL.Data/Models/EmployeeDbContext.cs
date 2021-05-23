using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreVuePostgreSQL.Data.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(){}
        public EmployeeDbContext(DbContextOptions options):base(options){}

        public DbSet<EmployeeModel> EmployeesMst { get; set; }

        public DbSet<LoginModel> EmployeeLogin { get; set; }
    }
}
