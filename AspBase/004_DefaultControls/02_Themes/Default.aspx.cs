using System;

namespace _02_Themes
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (IsPostBack)
                Theme = Request.Form["Themes"];
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Themes.Items.Add("Dark");
                Themes.Items.Add("Light");
            }
        }
    }
}