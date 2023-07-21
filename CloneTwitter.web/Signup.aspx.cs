using CloneTwitter.Message;
using CloneTwitter.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloneTwitter.web
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signup_click(object sender, EventArgs e)
        {
            UserSignupRequest userSignuprequest = new UserSignupRequest();

            userSignuprequest.NAME = name_txtbox.Text;
            userSignuprequest.PHONE = phone_txtbox.Text;
            userSignuprequest.EMAIL = email_txtbox.Text;
            userSignuprequest.USERNAME = username_txtbox.Text;
            userSignuprequest.PASSWORD = password_txtbox.Text;

            MessagesResponse userSignupResponse = UserSignupTransaction.Execute(userSignuprequest);
            UserSignupResponse usResponse = (UserSignupResponse)userSignupResponse;

            if(usResponse.Response == Enumaration.GeneralEnumarations.Response.error)
            {
                errortxtbox.Visible = true;
                errortxtbox.Text = string.Join(" , " ,usResponse.Notifications.Select(p=>p.Message).ToList());
                
            }
        }
    }
}