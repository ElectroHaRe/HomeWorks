using System;

namespace _01_InitLoadPreLoadEvents
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DateTime startTime;

        private string GetMessage(string eventName) =>
            $"{eventName} ({(DateTime.Now - startTime).Ticks.ToString()} ticks) <br />";

        protected void Page_PreInit(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            label.Text += GetMessage("PreInit");
        }

        protected void Page_Init(object sender, EventArgs e) =>
            label.Text += GetMessage("Init");

        protected void Page_InitComplete(object sender, EventArgs e) =>
            label.Text += GetMessage("InitComplete");

        protected void Page_PreLoad(object sender, EventArgs e) =>
            label.Text += GetMessage("PreLoad");

        protected void Page_Load(object sender, EventArgs e) =>
            label.Text += GetMessage("Load");

        protected void Page_LoadComplete(object sender, EventArgs e) =>
            label.Text += GetMessage("LoadComplete");

        protected void Page_PreRender(object sender, EventArgs e) =>
            label.Text += GetMessage("PreRender");

        protected void Page_PreRenderComplete(object sender, EventArgs e) =>
            label.Text += GetMessage("PreRenderComplete");

        protected void Page_SaveStateComplete(object sender, EventArgs e) =>
            label.Text += GetMessage("SaveStateComplete");

        protected void Page_Unload(object sender, EventArgs e) =>
            label.Text += GetMessage("Unload");
    }
}