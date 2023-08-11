using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloneTwitter.web
{
    public partial class ChatMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            top_postavatar.ImageUrl = CloneTwitter.Session.SessionHelper.GetUserPhoto(Convert.ToInt32(Session["UserId"]));
            top_postname.Text = CloneTwitter.Session.SessionHelper.GetName(Convert.ToInt32(Session["UserId"]));
            top_postusername.Text = "@" + CloneTwitter.Session.SessionHelper.GetUserName(Convert.ToInt32(Session["UserId"]));

        }
    }
}