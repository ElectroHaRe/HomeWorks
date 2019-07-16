using System;
using System.Windows;

namespace TimerCounter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler StartButtonClick;
        public event EventHandler PauseButtonClick;
        public event EventHandler StopButtonClick;

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StartButtonClick?.Invoke(sender, e);
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            PauseButtonClick?.Invoke(sender,e);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            StopButtonClick?.Invoke(sender,e);
        }
    }
}
