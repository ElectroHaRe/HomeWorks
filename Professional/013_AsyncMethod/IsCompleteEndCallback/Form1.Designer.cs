namespace IsCompleteEndCallback
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
            this.IsCompleteButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.CallbackButton = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IsCompleteButton
            // 
            this.IsCompleteButton.Location = new System.Drawing.Point(12, 12);
            this.IsCompleteButton.Name = "IsCompleteButton";
            this.IsCompleteButton.Size = new System.Drawing.Size(75, 23);
            this.IsCompleteButton.TabIndex = 0;
            this.IsCompleteButton.Text = "IsComplete";
            this.IsCompleteButton.UseVisualStyleBackColor = true;
            this.IsCompleteButton.Click += new System.EventHandler(this.IsCompleteButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(93, 12);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(75, 23);
            this.EndButton.TabIndex = 1;
            this.EndButton.Text = "End";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // CallbackButton
            // 
            this.CallbackButton.Location = new System.Drawing.Point(174, 12);
            this.CallbackButton.Name = "CallbackButton";
            this.CallbackButton.Size = new System.Drawing.Size(75, 23);
            this.CallbackButton.TabIndex = 2;
            this.CallbackButton.Text = "Callback";
            this.CallbackButton.UseVisualStyleBackColor = true;
            this.CallbackButton.Click += new System.EventHandler(this.CallbackButton_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.Location = new System.Drawing.Point(12, 41);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ReadOnly = true;
            this.MessageBox.Size = new System.Drawing.Size(237, 20);
            this.MessageBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 75);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.CallbackButton);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.IsCompleteButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IsCompleteButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Button CallbackButton;
        private System.Windows.Forms.TextBox MessageBox;
    }
}

