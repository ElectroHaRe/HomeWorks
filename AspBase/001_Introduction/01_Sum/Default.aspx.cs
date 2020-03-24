using System;

namespace _01_Sum
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Calculate_Click(object sender, EventArgs e)
        {
            result.Text = (int.Parse(firstSummand.Text) + int.Parse(secondSummand.Text)).ToString(); 
        }
    }
}