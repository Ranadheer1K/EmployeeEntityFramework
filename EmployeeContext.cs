using EmployeeEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeEntityFramework
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name = EmpDbConnectionString")
        {

        }

        public DbSet<Employee> employees { get; set; }
    }
}