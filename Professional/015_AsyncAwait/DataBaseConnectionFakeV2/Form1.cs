using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseConnectionFakeV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 500;
            timer.Tick += Tick;
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        string text = "";

        CancellationTokenSource cts;

        void Tick(object sender, EventArgs e)
        {
            if (textBox.Text == text)
                textBox.Text = string.Empty;
            else textBox.Text = text;
        }

        private async void ChangeMessages(string mainMessage, string lastMessage)
        {
            if (cts == null)
                cts = new CancellationTokenSource();
            else
            {
                cts.Cancel();
                cts.Dispose();
                cts = new CancellationTokenSource();
            }
            timer.Stop();
            textBox.Text = mainMessage;
            await Task.Factory.StartNew(() => Thread.Sleep(1000), cts.Token);
            textBox.Text = lastMessage;
            text = lastMessage;
            timer.Start();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ChangeMessages("Выполняется подключение к базе данных", "Данные получены");
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            ChangeMessages("Выполняется безопасный разрыв соединения", "Соединение разорвано");
        }
    }
}
