﻿using System;

namespace TimerCounter
{
    class Model
    {
        public Model()
        {
            isActive = false;
        }

        public bool isActive { get; private set; }
        DateTime start_time = new DateTime();
        TimeSpan last_time = new TimeSpan();

        public TimeSpan current_time
        {
            get
            {
                if (isActive)
                    return DateTime.Now - start_time + last_time;
                else return last_time;
            }
        }

        public void Start()
        {
            start_time = DateTime.Now;
            isActive = true;
        }

        public void Pause()
        {
            last_time = current_time;
            start_time = new DateTime();
            isActive = false;
        }

        public void Stop()
        {
            last_time = new TimeSpan();
            start_time = new DateTime();
            isActive = false;
        }
    }
}
