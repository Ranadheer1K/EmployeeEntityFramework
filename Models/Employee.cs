using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeEntityFramework.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Double Salary { get; set; }
        public string Designation { get; set; }
    }
}