using System;

namespace _02_Authorization
{
    public partial class SecurityPage : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            var userName = (new SecurityAuthorization()).CurrentUser;

            if (userName == null)
                Response.Redirect("Default.aspx");

            UserName.Text = userName;
        }
    }
}