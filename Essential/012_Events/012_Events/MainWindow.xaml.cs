using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _012_Events
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //textBox.IsReadOnly = true;
            new Presenter(this);
        }

        public event EventHandler PlayButtonClick;
        public event EventHandler PauseButtonClick;
        public event EventHandler StopButtonClick;

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            PlayButtonClick?.Invoke(sender,e);
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            PauseButtonClick?.Invoke(sender, e);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            StopButtonClick?.Invoke(sender, e);
        }
    }
}
