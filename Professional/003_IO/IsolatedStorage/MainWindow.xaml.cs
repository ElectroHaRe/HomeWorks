using System.IO;
using System.IO.IsolatedStorage;
using System.Windows;
using System.Windows.Media;

namespace IsolatedStorage
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (!user_storage.FileExists(config_name))
            {
                user_storage.CreateFile(config_name);
                SaveColor(Colors.White);
            }

            LoadColor();
        }

        IsolatedStorageFile user_storage = IsolatedStorageFile.GetMachineStoreForAssembly();
        IsolatedStorageFileStream file_stream;

        string config_name = "ColorSettings.config";

        private void SaveColor(Color color)
        {
            file_stream = new IsolatedStorageFileStream(config_name, FileMode.Open);
            using (BinaryWriter _writer = new BinaryWriter(file_stream))
            {
                _writer.Write(color.R);
                _writer.Write(color.G);
                _writer.Write(color.B);
                _writer.Write(color.A);
            }
            file_stream.Close();
        }

        private void LoadColor()
        {
            Color color = new Color();
            file_stream = new IsolatedStorageFileStream(config_name, FileMode.Open);
            using (BinaryReader _reader = new BinaryReader(file_stream))
            {
                color.R = _reader.ReadByte();
                color.G = _reader.ReadByte();
                color.B = _reader.ReadByte();
                color.A = _reader.ReadByte();
            }
            file_stream.Close();
            cp.SelectedColor = color;
            label.Background = new SolidColorBrush(color);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveColor(cp.SelectedColor.Value);
            MessageBox.Show("Your choice was saved...", "Message", MessageBoxButton.OK);
        }

        private void cp_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            Color current_color = cp.SelectedColor.Value;
            label.Background = new SolidColorBrush(current_color);
            if (current_color.R < 140 && current_color.G < 140 && current_color.A>140)
            {
                label.Foreground = new SolidColorBrush(Colors.White);
            } else label.Foreground = new SolidColorBrush(Colors.Black);
        }
    }
}
