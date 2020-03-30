using System;
using System.Xml;

namespace _02_Authorization
{
    public partial class AuthorizationPage : System.Web.UI.Page
    {
        private SecurityAuthorization securityAuthorization = new SecurityAuthorization();

        public bool LogPassChecker(string login, string password)
        {
            var document = new XmlDocument();
            document.Load(MapPath(@"~\App_Data\UsersList.xml"));
            var node = document.SelectSingleNode($@"//user[@login='{login}'][@password='{password}']");

            return node != null;
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            securityAuthorization.Checker = LogPassChecker;
            if (Request.QueryString["command"] == "signOut")
                securityAuthorization.SignOut();
        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            if (!securityAuthorization.Authorize(Login.Text, Password.Text))
                ErrorLabel.Visible = true;
            else ErrorLabel.Visible = false;
        }
    }
}