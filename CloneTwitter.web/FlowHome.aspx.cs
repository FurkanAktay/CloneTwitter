using CloneTwitter.Message;
using CloneTwitter.Transaction;
using CloneTwitter.Session;
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

            tweetbox_image.ImageUrl = CloneTwitter.Session.SessionHelper.GetUserPhoto(Convert.ToInt32(Session["UserId"]));
            top_postavatar.ImageUrl = CloneTwitter.Session.SessionHelper.GetUserPhoto(Convert.ToInt32(Session["UserId"]));
            top_postname.Text = CloneTwitter.Session.SessionHelper.GetName(Convert.ToInt32(Session["UserId"]));
            top_postusername.Text = "@" + CloneTwitter.Session.SessionHelper.GetUserName(Convert.ToInt32(Session["UserId"]));


            if (!IsPostBack)
            {
                // Örnek bir DataTable oluştur
                DataTable dataaTable = new DataTable();
                dataaTable.Columns.Add("ID", typeof(int));
                dataaTable.Columns.Add("Name", typeof(string));
                dataaTable.Rows.Add(1, "John");
                dataaTable.Rows.Add(2, "Jane");
                dataaTable.Rows.Add(3, "Michael");

                // GridView'ı veri kaynağı olarak ayarla
                //GridView1.DataSource = dataaTable;
                //GridView1.DataBind();
            }
        }

        protected void btnSharePost_Click(object sender, EventArgs e)
        {
            SharePostRequest sharePostRequest = new SharePostRequest();

            sharePostRequest.ID_USER = Convert.ToInt32(Session["UserId"]);
            sharePostRequest.USER_PHOTO = CloneTwitter.Session.SessionHelper.GetUserPhoto(Convert.ToInt32(Session["UserId"]));
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