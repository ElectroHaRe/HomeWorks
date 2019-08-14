namespace MultitaskRead2FilesAndWriteInToOne
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
            this.FileLabel1 = new System.Windows.Forms.Label();
            this.PathBox1 = new System.Windows.Forms.TextBox();
            this.FileLabel2 = new System.Windows.Forms.Label();
            this.PathBox2 = new System.Windows.Forms.TextBox();
            this.AsyncReadButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SyncReadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileLabel1
            // 
            this.FileLabel1.AutoSize = true;
            this.FileLabel1.Location = new System.Drawing.Point(9, 9);
            this.FileLabel1.Name = "FileLabel1";
            this.FileLabel1.Size = new System.Drawing.Size(32, 13);
            this.FileLabel1.TabIndex = 0;
            this.FileLabel1.Text = "File 1";
            // 
            // PathBox1
            // 
            this.PathBox1.Location = new System.Drawing.Point(12, 25);
            this.PathBox1.Name = "PathBox1";
            this.PathBox1.Size = new System.Drawing.Size(275, 20);
            this.PathBox1.TabIndex = 1;
            this.PathBox1.Click += new System.EventHandler(this.PathBox_1_Clicked);
            // 
            // FileLabel2
            // 
            this.FileLabel2.AutoSize = true;
            this.FileLabel2.Location = new System.Drawing.Point(296, 9);
            this.FileLabel2.Name = "FileLabel2";
            this.FileLabel2.Size = new System.Drawing.Size(32, 13);
            this.FileLabel2.TabIndex = 2;
            this.FileLabel2.Text = "File 2";
            // 
            // PathBox2
            // 
            this.PathBox2.Enabled = false;
            this.PathBox2.Location = new System.Drawing.Point(293, 25);
            this.PathBox2.Name = "PathBox2";
            this.PathBox2.Size = new System.Drawing.Size(278, 20);
            this.PathBox2.TabIndex = 3;
            this.PathBox2.Click += new System.EventHandler(this.PathBox_2_Clicked);
            // 
            // AsyncReadButton
            // 
            this.AsyncReadButton.Enabled = false;
            this.AsyncReadButton.Location = new System.Drawing.Point(574, 22);
            this.AsyncReadButton.Name = "AsyncReadButton";
            this.AsyncReadButton.Size = new System.Drawing.Size(104, 25);
            this.AsyncReadButton.TabIndex = 6;
            this.AsyncReadButton.Text = "AsyncRead";
            this.AsyncReadButton.UseVisualStyleBackColor = true;
            this.AsyncReadButton.Click += new System.EventHandler(this.AsyncReadButtonClicked);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(12, 64);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultTextBox.Size = new System.Drawing.Size(776, 374);
            this.ResultTextBox.TabIndex = 7;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(9, 48);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Result";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "FIle 1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "File 2";
            // 
            // SyncReadButton
            // 
            this.SyncReadButton.Enabled = false;
            this.SyncReadButton.Location = new System.Drawing.Point(684, 22);
            this.SyncReadButton.Name = "SyncReadButton";
            this.SyncReadButton.Size = new System.Drawing.Size(104, 25);
            this.SyncReadButton.TabIndex = 9;
            this.SyncReadButton.Text = "SyncRead";
            this.SyncReadButton.UseVisualStyleBackColor = true;
            this.SyncReadButton.Click += new System.EventHandler(this.SyncReadButtonClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SyncReadButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.AsyncReadButton);
            this.Controls.Add(this.PathBox2);
            this.Controls.Add(this.FileLabel2);
            this.Controls.Add(this.PathBox1);
            this.Controls.Add(this.FileLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FileLabel1;
        private System.Windows.Forms.TextBox PathBox1;
        private System.Windows.Forms.Label FileLabel2;
        private System.Windows.Forms.TextBox PathBox2;
        private System.Windows.Forms.Button AsyncReadButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button SyncReadButton;
    }
}

