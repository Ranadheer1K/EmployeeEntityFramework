using EmployeeEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeEntityFramework
{
    public partial class InsertEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeContext empContext = new EmployeeContext();
            Employee emp = new Employee() { Id = int.Parse(txtEmpId.Text), Name = txtEmpName.Text,
                           Salary = Double.Parse(txtEmpSal.Text), Designation = txtEmpDes.Text};
            empContext.employees.Add(emp);
            int recordsEffected = empContext.SaveChanges();
            Response.Write(recordsEffected + " Record Inserted");
        }
    }
}