using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Searcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Tick += ShowCurrentPathInfo;
        }

        Timer timer = new Timer();

        object block1 = new object();
        object block2 = new object();
        object block3 = new object();

        string CurrentDirectory;

        string Directory = String.Empty;

        string[] pathArray = new string[0];

        int TaskId = 0;

        bool flag = false;

        int directoryCount = 0;

        private void ShowCurrentPathInfo(object sender, EventArgs e)
        {
            if (flag)
            {
                StringBuilder builder = new StringBuilder();

                if (pathArray.Length > 0)
                {
                    for (int i = 0; i < pathArray.Length; i++)
                    {
                        builder.Append(pathArray[i]); builder.AppendLine();
                    }
                }
                else
                {
                    builder.Append("File not found");
                }
                OutputBox.Clear();
                OutputBox.AppendText(builder.ToString());
                timer.Stop();
                flag = false;
            }
            else
            {
                OutputBox.Text = CurrentDirectory;
            }
            OutputBox.AppendText(Environment.NewLine + "Directories : " + directoryCount.ToString());
        }

        private void SearchFileInDirectory(string fileName, DirectoryInfo directory)
        {
            lock (block1)
            {
                directoryCount++;
            }

            CurrentDirectory = directory.FullName;

            try
            {
                FileInfo[] file_info_array = directory.GetFiles(fileName);
                if (file_info_array.Length > 0)
                {
                    Array.Resize(ref pathArray, pathArray.Length + file_info_array.Length);

                    lock (block2)
                    {
                        for (int i = 0; i < file_info_array.Length; i++)
                        {
                            pathArray[i + pathArray.Length - file_info_array.Length] = file_info_array[i].FullName;
                        }
                    }
                }
            }
            catch
            {
                return;
            }

            DirectoryInfo[] sub_directory_array = directory.GetDirectories();
            Parallel.ForEach<DirectoryInfo>(sub_directory_array, d_info => SearchFileInDirectory(fileName, d_info));

            if (Task.CurrentId == TaskId)
            {
                lock (block3)
                {
                    flag = true;
                }
            }

            return;
        }

        private void PathBox_Click(object sender, EventArgs e)
        {
            if (PathDialog.ShowDialog() == DialogResult.OK)
            {
                Directory = PathDialog.SelectedPath;
                PathBox.Text = Directory;
                FindButton.Enabled = true;
            }
            else
            {
                FindButton.Enabled = false;
            }
        }

        private void SearchTask()
        {
            SearchFileInDirectory(Path.HasExtension(FileNameBox.Text) ? FileNameBox.Text : FileNameBox.Text + ".*", new DirectoryInfo(Directory));
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            directoryCount = 0;

            if (FileNameBox.Text == string.Empty)
            {
                OutputBox.Text = "The file name cannot be empty";
                return;
            }

            pathArray = new string[0];

            OutputBox.ReadOnly = true;
            timer.Start();

            Task task = new Task(SearchTask);
            TaskId = task.Id;
            task.Start();
        }
    }
}
