using System;
using System.Web.UI;

namespace _01_RequestCounter
{
    public partial class Default : Page
    {
        private int counter
        {
            get
            {
                object obj = Application["counter"];

                if (obj == null)
                    return 0;

                return (int)obj;
            }

            set => Application.Set("counter", value);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            label.Text = $"Запросов на сервер: {++counter}";
        }
    }
}