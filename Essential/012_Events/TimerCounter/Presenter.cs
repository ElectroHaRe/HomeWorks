using System;
using System.Windows.Threading;

namespace TimerCounter
{
    class Presenter
    {
        public Presenter(MainWindow window)
        {
            this.window = window;
            DispatcherTimer t = new DispatcherTimer();
            t.Interval = TimeSpan.FromMilliseconds(10);
            t.Tick += UpdateText;
            t.Start();
            window.StartButtonClick += StartTimer;
            window.PauseButtonClick += PauseTimer;
            window.StopButtonClick += StopTimer;
        }

        MainWindow window;
        Model timer = new Model();

        private void UpdateText(object sender, EventArgs e)
        {
            window.textBox.Text = timer.current_time.Minutes + " : " +
                timer.current_time.Seconds + " : " + timer.current_time.Milliseconds;
        }

        public void StartTimer(object sender,EventArgs e)
        {
            timer.Start();
        }

        public void PauseTimer(object sender, EventArgs e)
        {
            timer.Pause();
        }

        public void StopTimer(object sender, EventArgs e)
        {
            timer.Stop();
        }

    }
}
