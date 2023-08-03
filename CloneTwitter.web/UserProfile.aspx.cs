using CloneTwitter.Message;
using CloneTwitter.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloneTwitter.web
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataTable dtTable = new DataTable();

                GetPostRequest getPostRequest = new GetPostRequest();
                GetPostResponse getPostResponse = new GetPostResponse();

                getPostRequest.UserId = Convert.ToInt32(Session["UserId"]);
                getPostResponse = (GetPostResponse)GetPostTransaction.Execute(getPostRequest);

                repeaterExample.DataSource = getPostResponse.PostTable;
                repeaterExample.DataBind();
            }

            SharePostRequest sharePostRequest = new SharePostRequest();
            DataTable dataTable = new DataTable();

            //ProfContainer.Visible = false;
        }


        protected void btnProfileSettings_Click(object sender, EventArgs e)
        {

           //WidgetContanier.Visible = false;
           //ProfContainer.Visible = true;


        }


    }
}