using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace CloneTwitter.web
{
    public partial class FlowTrends : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable("Customers");

            // Add two columns to the DataTable object.
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));

            // Add two rows to the DataTable object.
            dataTable.Rows.Add("John", "Doe");
            dataTable.Rows.Add("Jane", "Doe");

            //GridView1.DataSource = dataTable;
            //GridView1.DataBind();
        }
    }
}