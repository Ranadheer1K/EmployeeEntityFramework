using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeEntityFramework
{
    public partial class RetrieveEmployess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeContext empContext = new EmployeeContext();
            var query = from emp in empContext.employees select emp;
            EmpGridView.DataSource = query.ToList();
            EmpGridView.DataBind();
        }
    }
}