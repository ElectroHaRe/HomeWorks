using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//using TemperatureConverter;

namespace TemperatureConverterWF
{
    public partial class TempConverter : Form
    {
        public TempConverter()
        {
            InitializeComponent();
            CelsiusTextBox.Text = 0.ToString();
            converterSpace = Assembly.Load("TemperatureConverter");
        }

        Assembly converterSpace;

        private void InputControllerOnTextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[-]{0,1}[0-9]+[\.,]{0,1}[0-9]*$";
            string temp = CelsiusTextBox.Text;
            if (Regex.IsMatch(temp, pattern))
            {
                return;
            }
            for (int i = CelsiusTextBox.Text.Length - 1; i >= 0; i--)
            {
                if (!Regex.IsMatch(CelsiusTextBox.Text[i].ToString(), @"[0-9-]")||
                    (i>0 && Regex.IsMatch(CelsiusTextBox.Text[i].ToString(),@"-")))
                {
                    CelsiusTextBox.Text = CelsiusTextBox.Text.Remove(i, 1);
                    break;
                }
            }
            CelsiusTextBox.SelectionStart = CelsiusTextBox.Text.Length;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (CelsiusTextBox.Text != "")
            {
                CelsiusTextBox.Text = Regex.Replace(CelsiusTextBox.Text, @"\.", ",");
                Type[] types = converterSpace.GetTypes();
                foreach (Type type in types)
                {
                    if (type.Name == "Converter")
                    {
                        foreach (MethodInfo method in type.GetMethods())
                        {
                            if (method.Name == "ConvertToFahrenheit")
                            {
                                object[] p = { Convert.ToDecimal(CelsiusTextBox.Text), TemperatureConverter.TemperatureScale.Celsius };
                                try { FahrenheitTextBox.Text = method.Invoke(this, p).ToString(); }
                                catch (Exception exception) { MessageBox.Show(exception.InnerException.Message, "Exception", MessageBoxButtons.OK); }
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
