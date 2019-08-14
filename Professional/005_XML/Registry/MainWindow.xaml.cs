using System;
using Microsoft.Win32;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Registry
{
    [Serializable]
    struct ColorSettings
    {
        public ColorSettings(Color? textColor, Color? backgroundColor)
        {
            if (textColor == null)
                _txtColor = null;
            else
                _txtColor = new byte[4] { textColor.Value.R, textColor.Value.G, textColor.Value.B, textColor.Value.A };

            if (backgroundColor == null)
                _bgColor = null;
            else
                _bgColor = new byte[4] { backgroundColor.Value.R, backgroundColor.Value.G, backgroundColor.Value.B, backgroundColor.Value.A };
        }
        public Color? TextColor
        {
            get
            {
                if (_txtColor == null)
                    return null;
                return new Color() { R = _txtColor[0], G = _txtColor[1], B = _txtColor[2], A = _txtColor[3] };
            }
        }

        public Color? BackgroundColor
        {
            get
            {
                if (_bgColor == null)
                    return null;
                return new Color() { R = _bgColor[0], G = _bgColor[1], B = _bgColor[2], A = _bgColor[3] };
            }
        }

        private byte[] _txtColor;
        private byte[] _bgColor;
    }

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeStyleBox();
            fontSizeTextBox.MaxLength = 2;
            fontSizeTextBox.Text = textBox.FontSize.ToString();
            InitializeFontState();

        }

        private void InitializeStyleBox()
        {
            foreach (var item in textBox.FontFamily.GetTypefaces())
            {
                foreach (var name in item.FaceNames)
                {
                    if (name.Key == System.Windows.Markup.XmlLanguage.GetLanguage("en-US"))
                        fontStyleBox.Items.Add(name.Value);
                }
            }
            foreach (var item in textBox.FontFamily.FamilyTypefaces)
            {
                fontStyleBox.SelectedItem = item.Style.ToString();
            }
        }

        private void InitializeFontState()
        {
            RegistryKey user_registry = Microsoft.Win32.Registry.CurrentUser;
            if (user_registry.OpenSubKey("HaReWPFProgram") == null)
            {
                user_registry = user_registry.CreateSubKey("HaReWPFProgram", true);
                SaveFontButton(null, null);
            }
            else user_registry = user_registry.OpenSubKey("HaReWPFProgram", true);

            fontSizeTextBox.Text = user_registry.GetValue("FontSize").ToString();
            fontStyleBox.SelectedItem = user_registry.GetValue("FontStyle");

            ApplyFontButton(null, null);
        }

        private Typeface GetTypeFace(string name, FontFamily fontFamily)
        {
            foreach (var typeFace in fontFamily.GetTypefaces())
            {
                foreach (var item in typeFace.FaceNames)
                {
                    if (item.Key == System.Windows.Markup.XmlLanguage.GetLanguage("en-US"))
                    {
                        if (item.Value == name)
                            return typeFace;
                    }
                }
            }
            return null;
        }

        private void BackgroundColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (backgroundColorPicker.SelectedColor != null)
            {
                textBox.Background = new SolidColorBrush(backgroundColorPicker.SelectedColor.Value);
            }
        }

        private void textColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            if (textColorPicker.SelectedColor != null)
            {
                textBox.Foreground = new SolidColorBrush(textColorPicker.SelectedColor.Value);
            }
        }

        private void ApplyFontButton(object sender, RoutedEventArgs e)
        {
            Typeface typeface = GetTypeFace(fontStyleBox.Text, textBox.FontFamily);

            textBox.FontFamily = typeface.FontFamily;
            textBox.FontStretch = typeface.Stretch;
            textBox.FontStyle = typeface.Style;
            textBox.FontWeight = typeface.Weight;

            textBox.FontSize = fontSizeTextBox.Text != string.Empty ? int.Parse(fontSizeTextBox.Text) : textBox.FontSize;

            foreach (var item in textBox.FontFamily.FamilyNames)
            {
                textBox.Text = fontStyleBox.SelectedItem.ToString();
            }
        }

        private void SaveFontButton(object sender, RoutedEventArgs e)
        {
            RegistryKey user_registry = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("HaReWPFProgram", true);
            user_registry.SetValue("FontSize", textBox.FontSize);
            user_registry.SetValue("FontStyle", fontStyleBox.SelectedItem);
        }

        private void FontSizeTextChanged(object sender, TextChangedEventArgs e)
        {
            string pattern = @"^[0-9]*$";
            if (Regex.IsMatch(fontSizeTextBox.Text, pattern))
            {
                return;
            }
            for (int i = fontSizeTextBox.Text.Length - 1; i >= 0; i--)
            {
                if (Regex.IsMatch(fontSizeTextBox.Text[i].ToString(), @"[0-9]") == false)
                {
                    fontSizeTextBox.Text = fontSizeTextBox.Text.Remove(i, 1);
                }
            }
            fontSizeTextBox.SelectionStart = fontSizeTextBox.Text.Length;
        }

        private void OnWindowClosed(object sender, EventArgs e)
        {
            ColorSettings settings = new ColorSettings(textColorPicker.SelectedColor, backgroundColorPicker.SelectedColor);
            using (Stream stream = new FileStream("color.config", FileMode.OpenOrCreate))
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(stream, settings);
            }
        }

        private void OnLoadedWindow(object sender, RoutedEventArgs e)
        {
            ColorSettings settings;
            using (Stream stream = new FileStream("color.config", FileMode.OpenOrCreate))
            {
                BinaryFormatter serializer = new BinaryFormatter();
                try
                {
                    settings = (ColorSettings)serializer.Deserialize(stream);
                }
                catch
                {
                    settings = new ColorSettings(null, null);
                }
            }
            textColorPicker.SelectedColor = settings.TextColor;
            backgroundColorPicker.SelectedColor = settings.BackgroundColor;
            textColorChanged(null, null);
            BackgroundColorChanged(null, null);
        }
    }
}
