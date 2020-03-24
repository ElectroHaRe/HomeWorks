using System;
using System.Web.UI;
using System.Xml;

namespace _02_SimpleAuthorization
{
    public partial class Default : Page
    {
        protected void SignIn_Click(object sender, EventArgs e)
        {
            var document = new XmlDocument();
            document.Load(Page.MapPath(@"~\App_Data\UsersList.xml"));

            if (document.SelectSingleNode($@"//user[@login='{login.Text}'][@password='{password.Text}']") != null)
            {
                Response.Redirect("UserPage.html");
            }
            else errorLabel.Visible = true;
        }
    }
}