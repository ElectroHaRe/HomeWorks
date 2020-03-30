using System;

namespace _02_Authorization
{
    public partial class Default : System.Web.UI.Page
    {
        private SecurityAuthorization securityAuthorization = new SecurityAuthorization();

        protected void Page_PreInit(object sender,EventArgs e)
        {
            if (string.IsNullOrEmpty(securityAuthorization.CurrentUser))
                Response.Redirect("AuthorizationPage.aspx");
        }
    }
}