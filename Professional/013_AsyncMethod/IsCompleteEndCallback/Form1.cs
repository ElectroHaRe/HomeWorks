using System;
using System.Threading;
using System.Windows.Forms;

namespace IsCompleteEndCallback
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            action = DoSomeAction;
        }

        Action action;
        bool callback = false;

        private void DoSomeAction()
        {
            Thread.Sleep(2000);
        }

        private void WriteStartMessage()
        {
            MessageBox.Clear();
            MessageBox.AppendText("Ожидайте 2 секунды");
        }

        private void IsCompleteButton_Click(object sender, EventArgs e)
        {
            WriteStartMessage();
            IAsyncResult async_result = action.BeginInvoke(null, null);
            while (true)
            {
                MessageBox.Text = "IsCompleted";
                if (async_result.IsCompleted)
                    break;
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            WriteStartMessage();
            IAsyncResult async_result = action.BeginInvoke(null, null);
            action.EndInvoke(async_result);
            MessageBox.Text = "End Invoke";
        }

        private void CallbackMethod(IAsyncResult result)
        {
            callback = true;
        }

        private void CallbackButton_Click(object sender, EventArgs e)
        {
            WriteStartMessage();
            IAsyncResult async_result = action.BeginInvoke(CallbackMethod,"The end");
            while (true)
            {
                if (callback)
                {
                    MessageBox.Text = "Callback : The End";
                    break;
                }
            }
        }
    }
}
