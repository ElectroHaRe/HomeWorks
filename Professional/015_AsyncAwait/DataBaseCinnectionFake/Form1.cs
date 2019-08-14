using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseCinnectionFake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Tick += UpdateMessage;
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        string currentMessage = string.Empty;

        private void UpdateMessage(object sender, EventArgs e)
        {
            OutputBox.Clear();
            OutputBox.AppendText(currentMessage);
        }

        private void ShowMessageWithInterval(object message)
        {
            while (timer.Enabled)
            {
                Thread.Sleep(500);
                currentMessage = string.Empty;
                Thread.Sleep(500);
                currentMessage = message as string;
            }
        }

        private async void ShowMessageWithIntervalAsync(string message)
        {
            await Task.Factory.StartNew(ShowMessageWithInterval, message as object);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {

            timer.Stop();
            Thread.Sleep(1000);
            currentMessage = "Подключен к базе данных";
            timer.Start();
            ShowMessageWithIntervalAsync("Данные получены");
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Thread.Sleep(1000);
            currentMessage = "Соединение разорвано";
            timer.Start();
            ShowMessageWithIntervalAsync("Соединение разорвано");
        }
    }
}
