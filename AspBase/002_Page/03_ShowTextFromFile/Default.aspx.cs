using System;
using System.IO;

namespace _03_ShowTextFromFile
{
    public partial class Default : System.Web.UI.Page
    {
        StreamReader sr;

        protected void Page_Load(object sender, EventArgs e)
        {
            sr = new StreamReader(MapPath("App_Data/TextSource.txt"));
            label.Text += sr.ReadToEnd();
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            sr.Close();
        }
    }
}