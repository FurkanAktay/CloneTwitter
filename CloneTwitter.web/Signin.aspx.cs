using CloneTwitter.Message;
using CloneTwitter.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static CloneTwitter.Enumaration.GeneralEnumarations;

namespace CloneTwitter.web
{
    public partial class Signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signin_click(object sender, EventArgs e)
        {
            UserSigninRequest userSigninRequest = new UserSigninRequest();

            userSigninRequest.PUEtext = peuname_txtbox.Text;
            userSigninRequest.PASSWORD = password_txtbox.Text;

            MessagesResponse userSigninResonse = UserSigninTransaction.Execute(userSigninRequest);
            UserSigninResponse usignResponse = (UserSigninResponse)userSigninResonse;

            if (usignResponse.Response == Enumaration.GeneralEnumarations.Response.error)
            {
                //errortxtbox.Visible = true;
                //errortxtbox.Text = string.Join(" , \n", usignResponse.Notifications.Select(p => p.Message).ToList());
                string error = string.Join(" , ", usignResponse.Notifications.Select(p => p.Message).ToList());
                Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "showMessageBox('" + error + "')", true);

            }


            if (usignResponse != null && usignResponse.ID_USER >0) {

                Session["UserId"] = usignResponse.ID_USER;
                Response.Redirect("~/FlowHome.aspx");
            }
            else
            {

            }
        }
    }
}