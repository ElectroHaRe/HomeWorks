using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace _01_CheckBoxList
{
    public partial class Default : System.Web.UI.Page
    {
        private List<ListItem> daysWeekList
        {
            get
            {
                var list = new List<ListItem>();

                var moonday = new ListItem("Moonday", 1.ToString());
                var tuesday = new ListItem("Tuesday", 2.ToString());
                var wednesday = new ListItem("Wednesday", 3.ToString());
                var thursday = new ListItem("Thursday", 4.ToString());
                var friday = new ListItem("Friday", 5.ToString());
                var saturday = new ListItem("Saturday", 6.ToString());
                var sunday = new ListItem("Sunday", 7.ToString());

                saturday.Selected = true;
                sunday.Selected = true;

                list.Add(moonday);
                list.Add(tuesday);
                list.Add(wednesday);
                list.Add(thursday);
                list.Add(friday);
                list.Add(saturday);
                list.Add(sunday);

                return list;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DaysWeek.Items.AddRange(daysWeekList.ToArray());
            }
        }
    }
}