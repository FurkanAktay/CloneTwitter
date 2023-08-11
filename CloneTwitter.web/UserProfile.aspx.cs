using CloneTwitter.Message;
using CloneTwitter.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static CloneTwitter.Enumaration.GeneralEnumarations;

namespace CloneTwitter.web
{
    public partial class UserProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataTable dtProfile = new DataTable();

                GetPersImgRequest persImgRequest = new GetPersImgRequest();
                GetPersImgResponse persImgResponse = new GetPersImgResponse();

                persImgRequest.UserId = Convert.ToInt32(Session["UserId"]);
                persImgResponse = (GetPersImgResponse)GetPersImgTransaction.Execute(persImgRequest);

                repeaterprofile.DataSource = persImgResponse.PostTable;
                repeaterprofile.DataBind();


            }

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

            top_postavatar.ImageUrl = CloneTwitter.Session.SessionHelper.GetUserPhoto(Convert.ToInt32(Session["UserId"]));
            top_postname.Text = CloneTwitter.Session.SessionHelper.GetName(Convert.ToInt32(Session["UserId"]));
            top_postusername.Text = "@" +  CloneTwitter.Session.SessionHelper.GetUserName(Convert.ToInt32(Session["UserId"]));
            
            //top_profilename.Text = "1";
            //top_profileusername.Text = "2";

        }


        protected void Savebtn_Click(object sender, EventArgs e)
        {

           PersImgRequest persImgRequest = new PersImgRequest();

            persImgRequest.UserID = Convert.ToInt32(Session["UserId"]);
            persImgRequest.ProfilePic = profPhotoUrl_txtbox.Text;
            persImgRequest.ProfileBgPic = bgPhotoUrl_txtbox.Text;
            persImgRequest.ProfileBio = bgText_txtbox.Text;

            MessagesResponse persImgResponse = PersImageTransactions.Execute(persImgRequest);
            PersImgResponse piResponse = (PersImgResponse)persImgResponse;

            if (piResponse.Response == Enumaration.GeneralEnumarations.Response.error)
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "showMessageBox('Kayıt yapılamamıstır!')", true);


            }



            Response.Redirect(Request.RawUrl);

        }

    }
}