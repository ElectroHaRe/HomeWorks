using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _012_Events
{
    class Presenter
    {
        System.Timers.Timer t = new System.Timers.Timer();

        public Presenter(MainWindow window)
        {
            main_window = window;
            main_window.PlayButtonClick += StartTimer;
            main_window.PauseButtonClick += PauseTimer;
            main_window.StopButtonClick += StopTimer;
            t.AutoReset = false;
            t.Interval = 500;
            t.Elapsed += UpdateText;
            t.Start();
        }

        private void UpdateText(object sender, System.Timers.ElapsedEventArgs e)
        {
            main_window.textBox.Text = timer.currentTime.Seconds.ToString();
        }

        object locker = new object();

        Timer timer = new Timer();
        MainWindow main_window;

        void StartTimer(object sender, EventArgs e)
        {
            timer.Start();
            t.Start();
        }

        void PauseTimer(object sender, EventArgs e)
        {
            timer.Pause();
        }

        void StopTimer(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
