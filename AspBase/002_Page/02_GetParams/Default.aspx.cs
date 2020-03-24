using System;

namespace _02_GetParams
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            label.Text += "*For create get parameter, just add ?paramName=paramValue (use & for more params) to your URL <br /><br />";
            label.Text += "GetParams: <br />";
            foreach (var getParam in Request.QueryString.AllKeys)
            {
                label.Text += $"{getParam} = {Request.QueryString[getParam].ToString()} <br />";
            }
        }
    }
}