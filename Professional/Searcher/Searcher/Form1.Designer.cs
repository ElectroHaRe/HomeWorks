namespace Searcher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PathBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(194, 25);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(513, 20);
            this.PathBox.TabIndex = 0;
            this.PathBox.Click += new System.EventHandler(this.PathBox_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(9, 9);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FileNameLabel.TabIndex = 1;
            this.FileNameLabel.Text = "File Name";
            // 
            // FindButton
            // 
            this.FindButton.Enabled = false;
            this.FindButton.Location = new System.Drawing.Point(713, 23);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 68);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputBox.Size = new System.Drawing.Size(776, 100);
            this.OutputBox.TabIndex = 3;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(9, 52);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(79, 13);
            this.OutputLabel.TabIndex = 4;
            this.OutputLabel.Text = "Search Results";
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(12, 25);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(176, 20);
            this.FileNameBox.TabIndex = 5;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(191, 9);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(49, 13);
            this.PathLabel.TabIndex = 6;
            this.PathLabel.Text = "Directory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 186);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.PathBox);
            this.Name = "Form1";
            this.Text = "File Searcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.FolderBrowserDialog PathDialog;
    }
}

