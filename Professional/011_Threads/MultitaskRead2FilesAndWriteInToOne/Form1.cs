using System;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace MultitaskRead2FilesAndWriteInToOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringBuilder result = new StringBuilder();
        object block = new object();

        private void Task(object path)
        {
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            StringBuilder _result = ReadFile(path as string);
            timer.Stop();
            lock (block)
            {
                result.Append("Поток "); result.Append(Thread.CurrentThread.ManagedThreadId);
                result.Append(" завершил свою работу");
                result.AppendLine();
                result.AppendLine();
               // result.Append(_result);
                result.AppendLine();
                result.Append("Затрачено времени : "); result.Append(timer.Elapsed.Ticks); result.Append(" ticks");
                result.Append(Environment.NewLine); result.Append(new string('_', 30)); result.AppendLine(); result.AppendLine();
            }
        }

        private StringBuilder ReadFile(string path)
        {
            StringBuilder builder = new StringBuilder();
            using (StreamReader stream = new StreamReader(new FileStream(path, FileMode.Open), Encoding.Default))
            {
                while (stream.Peek() >= 0)
                {
                    builder.Append(stream.ReadLine());
                    builder.AppendLine();
                }
            }
            return builder;
        }

        private void PathBox_1_Clicked(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PathBox1.Text = openFileDialog1.FileName;
                PathBox2.Enabled = true;
            }
        }

        private void PathBox_2_Clicked(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                PathBox2.Text = openFileDialog2.FileName;
                AsyncReadButton.Enabled = true;
                SyncReadButton.Enabled = true;
            }
        }

        private void AsyncReadButtonClicked(object sender, EventArgs e)
        {
            result = new StringBuilder();
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            ResultTextBox.Enabled = true;
            result.Append("Попытка асинхронного чтения файлов"); result.Append(" : ");
            result.AppendLine(); result.AppendLine();
            Thread thread1 = new Thread(Task);
            Thread thread2 = new Thread(Task);
            thread1.Start(PathBox1.Text);
            thread2.Start(PathBox2.Text);
            thread1.Join();
            thread2.Join();
            result.Append("Всего затрачено времени : "); timer.Stop(); result.Append(timer.Elapsed.Ticks); result.Append(" ticks");
            result.Append(Environment.NewLine); result.Append(new string('_', 30)); result.AppendLine();
            ResultTextBox.Text = result.ToString();
        }

        private void SyncReadButtonClicked(object sender, EventArgs e)
        {
            result = new StringBuilder();
            Stopwatch timer = Stopwatch.StartNew();
            timer.Start();
            result.Append("Попытка синхронного чтения файлов"); result.Append(" : ");
            result.AppendLine(); result.AppendLine();
            Task(PathBox1.Text);
            Task(PathBox2.Text);
            result.Append("Всего затрачено времени : "); timer.Stop(); result.Append(timer.Elapsed.Ticks); result.Append(" ticks");
            result.Append(Environment.NewLine); result.Append(new string('_', 30)); result.AppendLine();
            ResultTextBox.Text = result.ToString();
        }
    }
}
