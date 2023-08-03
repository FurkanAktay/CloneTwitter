using CloneTwitter.Message;
using CloneTwitter.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloneTwitter.web
{
    public partial class FlowHome : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                DataTable dtTable = new DataTable();

                GetPostRequest getPostRequest = new GetPostRequest();
                GetPostResponse getPostResponse = new GetPostResponse();

                getPostRequest.UserId =Convert.ToInt32(Session["UserId"]);
                getPostResponse = (GetPostResponse)GetPostTransaction.Execute(getPostRequest);

                repeaterExample.DataSource = getPostResponse.PostTable;
                repeaterExample.DataBind();
            }

            SharePostRequest sharePostRequest = new SharePostRequest();
            DataTable dataTable = new DataTable();

            attachlink_txt.Visible = false;

        }

        protected void btnSharePost_Click(object sender, EventArgs e)
        {
            SharePostRequest sharePostRequest = new SharePostRequest();

            sharePostRequest.ID_USER = 1;
            sharePostRequest.USER_PHOTO = "https://i.pinimg.com/originals/a6/58/32/a65832155622ac173337874f02b218fb.png";
            sharePostRequest.POST_CONTENT = PostContent_txtbox.Text;
            sharePostRequest.POST_IMGCONTENT = attachlink_txt.Text;


            MessagesResponse sharePostResponse = SharePostTransaction.Execute(sharePostRequest);
            SharePostResponse spResponse = (SharePostResponse)sharePostResponse;

            ClientScript.RegisterStartupScript(this.GetType(), "addHTMLScript", "addHTMLToFeed();", true);
            PostContent_txtbox.Text = string.Empty;
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAttach_Click(object sender, EventArgs e)
        {
            attachlink_txt.Visible = true;


        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);

        }


        protected void rptOrnek_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            
        }
    }
}