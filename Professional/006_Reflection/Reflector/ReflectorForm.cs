using System;
using System.Reflection;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Reflector
{
    public partial class ReflectorForm : Form
    {
        public ReflectorForm()
        {
            InitializeComponent();
        }

        Assembly file = null;

        private void OpenFileEvent(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder text = new StringBuilder();
                string path = openFileDialog.FileName;
                PathBox.Text = path;
                textBox.Clear();
                try
                {
                    file = Assembly.LoadFile(path);
                }
                catch (Exception exception)
                {
                    textBox.ForeColor = System.Drawing.Color.Red;
                    textBox.Text += "Файл " + Path.GetFileName(path) + " не удалось загрузить..." + Environment.NewLine + Environment.NewLine;
                    textBox.Text += "Ошибка : " + exception.Message;
                    file = null;
                    return;
                }

                textBox.ForeColor = System.Drawing.Color.Black;
                ShowAssemblyInfo();
            }
        }

        private void ShowAssemblyInfo()
        {
            if (file == null)
                return;
            StringBuilder text = new StringBuilder();
            string path = openFileDialog.FileName;
            textBox.Clear();

            text.Append("Файл "); text.Append(Path.GetFileName(path)); text.Append(" успешно загружен..."); text.AppendLine();
            text.Append(Environment.NewLine);
            text.Append("Сборка : "); text.Append(file.FullName); text.Append(Environment.NewLine);
            text.Append(new string('_', 30)); text.Append(Environment.NewLine);
            text.AppendLine();

            text.Append(GetTypeInfo(file.GetTypes()));
            textBox.Text += text;
        }

        private string GetTypeInfo(Type[] types)
        {
            StringBuilder text = new StringBuilder();
            foreach (Type type in types)
            {
                text.Append(GetAttributes(type));
                text.Append("Тип : "); text.Append(type.Name);
                text.AppendLine(); text.AppendLine();

                if (CtorCheckBox.CheckState == CheckState.Checked)
                    text.Append(GetMemberInfo(type.GetConstructors()));
                if(PropertiesCheckBox.CheckState == CheckState.Checked)
                text.Append(GetMemberInfo(type.GetProperties()));
                if (EventsCheckBox.CheckState == CheckState.Checked)
                    text.Append(GetMemberInfo(type.GetEvents()));
                if (FieldsCheckBox.CheckState == CheckState.Checked)
                    text.Append(GetMemberInfo(type.GetFields()));
                if (MethodsCheckBox.CheckState == CheckState.Checked)
                    text.Append(GetMemberInfo(type.GetMethods()));

                if (NestedCheckBox.CheckState == CheckState.Checked && type.GetNestedTypes().Length > 0)
                {
                    text.AppendLine();
                    text.Append(GetMemberInfo(type.GetNestedTypes()));
                }

                for (int i = 0; i < 5; i++)
                {
                    if (i == 2)
                        text.Append(new string('_', 10));
                    else
                        text.AppendLine();
                }
            }

            return text.ToString();
        }

        private string GetMemberInfo(MemberInfo[] items)
        {
            StringBuilder text = new StringBuilder();
            PropertyInfo a;
            foreach (var item in items)
            {
                text.Append(GetAttributes(item));
                text.Append(item.MemberType); text.Append(" : ");
                if (item is MethodInfo)
                {
                    text.Append((item as MethodInfo).ReturnType.Name); text.Append(" ");
                }
                if (item is PropertyInfo)
                {
                    text.Append((item as PropertyInfo).GetMethod.ReturnType.Name); text.Append(" ");
                }
                text.Append(item.Name);
                if (item is ConstructorInfo || item is MethodInfo)
                {
                    dynamic temp = item;
                    var ps = temp.GetParameters();
                    text.Append("( ");
                    for (int i = 0; i < ps.Length; i++)
                    {
                        text.Append(ps[i].ParameterType.Name); text.Append(" "); text.Append(ps[i].Name);
                        if (i != ps.Length - 1)
                            text.Append(" , ");
                    }
                    text.Append(" )");
                }
                text.AppendLine();
            }
            return text.ToString();
        }

        private string GetAttributes(MemberInfo item)
        {
            if (AttributesCheckBox.CheckState != CheckState.Checked || item.GetCustomAttributes(false).Length == 0)
                return String.Empty;
            StringBuilder text = new StringBuilder();
            text.Append("   [ ");
            object[] attrebute_collection = item.GetCustomAttributes(false);
            for (int i = 0; i < attrebute_collection.Length; i++)
            {
                text.Append(attrebute_collection[i].GetType().Name);

                if (i != attrebute_collection.Length - 1)
                    text.Append(" , ");
            }
            text.Append(" ]");
            text.AppendLine();
            return text.ToString();
        }

        private string GetAttributes(Type item)
        {
            if (AttributesCheckBox.CheckState != CheckState.Checked || item.GetCustomAttributes(false).Length == 0)
                return String.Empty;
            StringBuilder text = new StringBuilder();
            text.Append("   [ ");
            object[] attrebute_collection = item.GetCustomAttributes(false);
            for (int i = 0; i < attrebute_collection.Length; i++)
            {
                text.Append(attrebute_collection[i].GetType().Name);

                if (i != attrebute_collection.Length - 1)
                    text.Append(" , ");
            }
            text.Append(" ]");
            text.AppendLine();
            return text.ToString();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            ShowAssemblyInfo();
        }
    }
}
