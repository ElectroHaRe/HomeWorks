using System;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace _03_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Number_Click(object sender, EventArgs e) =>
            OutputLabel.Text += (sender as Button)?.Text;

        protected void ClearAll_Click(object sender, EventArgs e) =>
            OutputLabel.Text = string.Empty;

        protected void ClearLast_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OutputLabel.Text))
                return;

            char last = OutputLabel.Text[OutputLabel.Text.Length - 1];

            if (last.ToString() == " ")
                OutputLabel.Text = OutputLabel.Text.Remove(OutputLabel.Text.Length - 3, 3);
            else OutputLabel.Text = OutputLabel.Text.Remove(OutputLabel.Text.Length - 1, 1);
        }

        protected void Sign_Click(object sender, EventArgs e)
        {
            if (sender.Equals(Minus) && (string.IsNullOrEmpty(OutputLabel.Text) ||
                OutputLabel.Text[OutputLabel.Text.Length - 1].ToString() == " "))
            {
                OutputLabel.Text += Minus.Text;
                return;
            }

            if (string.IsNullOrEmpty(OutputLabel.Text))
                OutputLabel.Text += 0;

            if (OutputLabel.Text[OutputLabel.Text.Length - 1].ToString() == Separator.Text)
                OutputLabel.Text += 0;

            if (OutputLabel.Text[OutputLabel.Text.Length - 1].ToString() != " ")
                OutputLabel.Text += $" {(sender as Button).Text} ";
        }

        string DecimalExpr = @"[-]{0,1}\d+([.,]{1}\d+){0,1}";
        string DivAndMultExpr => DecimalExpr + @"[ ]{1}[×÷]{1}[ ]{1}" + DecimalExpr;
        string AddAndDiffExpr => DecimalExpr + @"[ ]{1}[+-]{1}[ ]{1}" + DecimalExpr;

        protected void Result_Click(object sender, EventArgs e)
        {
            decimal a = 0;
            decimal b = 0;
            decimal result = 0;

            if (!string.IsNullOrEmpty(OutputLabel.Text) &&
                OutputLabel.Text[OutputLabel.Text.Length - 1].ToString() == " ")
                ClearLast_Click(null, null);

            string text = OutputLabel.Text;
            Match match; UpdateMatch(DivAndMultExpr);

            while (!string.IsNullOrEmpty(match?.ToString()))
            {
                UpdateArgs();

                if (match.ToString().Contains("÷"))
                {
                    if (b == 0)
                    {
                        ResultLabel.ForeColor = System.Drawing.Color.Red;
                        ResultLabel.Text = $"Ошибка деления на ноль: {a} ÷ {b}";
                        return;
                    }
                    result = a / b;
                }
                else result = a * b;

                UpdateText();
                UpdateMatch(DivAndMultExpr);
            }

            UpdateMatch(AddAndDiffExpr);

            while (!string.IsNullOrEmpty(match?.ToString()))
            {
                UpdateArgs();

                if (match.ToString().Contains("+"))
                    result = a + b;
                else result = a - b;

                UpdateText();
                UpdateMatch(AddAndDiffExpr);
            }

            ResultLabel.ForeColor = System.Drawing.Color.Black;
            ResultLabel.Text = OutputLabel.Text;
            OutputLabel.Text = text;

            void UpdateArgs()
            {
                a = decimal.Parse(Regex.Match(match.Value, DecimalExpr).ToString());
                b = decimal.Parse(Regex.Match(match.Value, @"[ ]" + DecimalExpr).ToString());
            }

            void UpdateText()
            {
                int i = text.IndexOf(match.Value);
                text = text.Remove(i, match.Value.Length).Insert(i, result.ToString());
            }

            void UpdateMatch(string expr)
            {
                match = Regex.Match(text, expr);
            }
        }

        protected void Separator_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OutputLabel.Text))
                OutputLabel.Text += 0;

            if (OutputLabel.Text[OutputLabel.Text.Length - 1].ToString() == (sender as Button).Text)
                return;

            if (Regex.Match(OutputLabel.Text, DecimalExpr + "$").ToString().Contains((sender as Button).Text))
                return;

            OutputLabel.Text += (sender as Button).Text;
        }
    }
}