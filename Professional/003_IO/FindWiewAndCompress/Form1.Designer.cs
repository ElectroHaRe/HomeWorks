namespace FindWiewAndCompress
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
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.CompressButton = new System.Windows.Forms.Button();
            this.ZipFileNameBox = new System.Windows.Forms.TextBox();
            this.FaleNameLabel = new System.Windows.Forms.Label();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.ZipFileNameLabel = new System.Windows.Forms.Label();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(79, 12);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(123, 20);
            this.FileNameBox.TabIndex = 0;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(208, 10);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(79, 38);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(204, 20);
            this.PathBox.TabIndex = 2;
            this.PathBox.Click += new System.EventHandler(this.PathBox_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 106);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(271, 364);
            this.TextBox.TabIndex = 3;
            // 
            // CompressButton
            // 
            this.CompressButton.Location = new System.Drawing.Point(208, 474);
            this.CompressButton.Name = "CompressButton";
            this.CompressButton.Size = new System.Drawing.Size(75, 23);
            this.CompressButton.TabIndex = 5;
            this.CompressButton.Text = "Compress";
            this.CompressButton.UseVisualStyleBackColor = true;
            this.CompressButton.Click += new System.EventHandler(this.CompressButton_Click);
            // 
            // ZipFileNameBox
            // 
            this.ZipFileNameBox.Location = new System.Drawing.Point(96, 476);
            this.ZipFileNameBox.Name = "ZipFileNameBox";
            this.ZipFileNameBox.Size = new System.Drawing.Size(106, 20);
            this.ZipFileNameBox.TabIndex = 4;
            // 
            // FaleNameLabel
            // 
            this.FaleNameLabel.AutoSize = true;
            this.FaleNameLabel.Location = new System.Drawing.Point(12, 15);
            this.FaleNameLabel.Name = "FaleNameLabel";
            this.FaleNameLabel.Size = new System.Drawing.Size(61, 13);
            this.FaleNameLabel.TabIndex = 6;
            this.FaleNameLabel.Text = "FIle Name :";
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(12, 41);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(52, 13);
            this.FilePathLabel.TabIndex = 7;
            this.FilePathLabel.Text = "Find Path";
            // 
            // ZipFileNameLabel
            // 
            this.ZipFileNameLabel.AutoSize = true;
            this.ZipFileNameLabel.Location = new System.Drawing.Point(12, 479);
            this.ZipFileNameLabel.Name = "ZipFileNameLabel";
            this.ZipFileNameLabel.Size = new System.Drawing.Size(78, 13);
            this.ZipFileNameLabel.TabIndex = 8;
            this.ZipFileNameLabel.Text = "Zip File Name :";
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(79, 67);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ReadOnly = true;
            this.MessageBox.Size = new System.Drawing.Size(204, 20);
            this.MessageBox.TabIndex = 9;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 70);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(50, 13);
            this.MessageLabel.TabIndex = 10;
            this.MessageLabel.Text = "Message";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(123, 90);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(44, 13);
            this.TextLabel.TabIndex = 11;
            this.TextLabel.Text = "FileText";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 507);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.ZipFileNameLabel);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.FaleNameLabel);
            this.Controls.Add(this.CompressButton);
            this.Controls.Add(this.ZipFileNameBox);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FileNameBox);
            this.Name = "Form1";
            this.Text = "HW_003_IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button CompressButton;
        private System.Windows.Forms.TextBox ZipFileNameBox;
        private System.Windows.Forms.Label FaleNameLabel;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Label ZipFileNameLabel;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

