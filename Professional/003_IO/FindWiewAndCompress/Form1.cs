using System;
using System.IO;
using System.Windows.Forms;

namespace FindWiewAndCompress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CompressButton.Enabled = false;
            ZipFileNameBox.Enabled = false;
            MessageBox.Text = "Заполните поля для поиска...";
        }

        string file_name = "";

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (FileNameBox.Text != "" && PathBox.Text != "")
            {
                file_name = FileWorker.FindFile(FileNameBox.Text, PathBox.Text);
                if (Path.HasExtension(file_name))
                {
                    TextBox.Text = FileWorker.GetText(file_name);
                    CompressButton.Enabled = true;
                    ZipFileNameBox.Enabled = true;
                    MessageBox.Text = file_name;
                }
                else
                {
                    CompressButton.Enabled = false;
                    ZipFileNameBox.Enabled = false;
                    MessageBox.Text = "Файл не найден...";
                }
            }
        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            if (file_name == null)
                return;

            if (file_name != "" && ZipFileNameBox.Text != "")
            {
                FileWorker.CompressToZip(file_name, ZipFileNameBox.Text);
                TextBox.Text = FileWorker.DecompressToString(Path.GetDirectoryName(file_name) + ZipFileNameBox.Text);
                MessageBox.Text = Path.GetDirectoryName(file_name) + ZipFileNameBox.Text + ".zip";
            }
        }

        private void PathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PathBox_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                PathBox.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
