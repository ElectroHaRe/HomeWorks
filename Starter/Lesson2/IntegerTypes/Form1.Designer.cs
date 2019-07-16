namespace IntegerTypes
{
    partial class TypeLimitsForm
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
            this.byteButton = new System.Windows.Forms.Button();
            this.sbyteButton = new System.Windows.Forms.Button();
            this.shortButton = new System.Windows.Forms.Button();
            this.ushortButton = new System.Windows.Forms.Button();
            this.ulongButton = new System.Windows.Forms.Button();
            this.longButton = new System.Windows.Forms.Button();
            this.uintButton = new System.Windows.Forms.Button();
            this.intButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // byteButton
            // 
            this.byteButton.Location = new System.Drawing.Point(20, 20);
            this.byteButton.Name = "byteButton";
            this.byteButton.Size = new System.Drawing.Size(80, 25);
            this.byteButton.TabIndex = 0;
            this.byteButton.Text = "byte";
            this.byteButton.UseVisualStyleBackColor = true;
            this.byteButton.Click += new System.EventHandler(this.byteButton_Click);
            // 
            // sbyteButton
            // 
            this.sbyteButton.Location = new System.Drawing.Point(120, 20);
            this.sbyteButton.Name = "sbyteButton";
            this.sbyteButton.Size = new System.Drawing.Size(80, 25);
            this.sbyteButton.TabIndex = 1;
            this.sbyteButton.Text = "sbyte";
            this.sbyteButton.UseVisualStyleBackColor = true;
            this.sbyteButton.Click += new System.EventHandler(this.sbyteButton_Click);
            // 
            // shortButton
            // 
            this.shortButton.Location = new System.Drawing.Point(220, 20);
            this.shortButton.Name = "shortButton";
            this.shortButton.Size = new System.Drawing.Size(80, 25);
            this.shortButton.TabIndex = 2;
            this.shortButton.Text = "short";
            this.shortButton.UseVisualStyleBackColor = true;
            this.shortButton.Click += new System.EventHandler(this.shortButton_Click);
            // 
            // ushortButton
            // 
            this.ushortButton.Location = new System.Drawing.Point(320, 20);
            this.ushortButton.Name = "ushortButton";
            this.ushortButton.Size = new System.Drawing.Size(80, 25);
            this.ushortButton.TabIndex = 3;
            this.ushortButton.Text = "ushort";
            this.ushortButton.UseVisualStyleBackColor = true;
            this.ushortButton.Click += new System.EventHandler(this.ushortButton_Click);
            // 
            // ulongButton
            // 
            this.ulongButton.Location = new System.Drawing.Point(320, 60);
            this.ulongButton.Name = "ulongButton";
            this.ulongButton.Size = new System.Drawing.Size(80, 25);
            this.ulongButton.TabIndex = 7;
            this.ulongButton.Text = "ulong";
            this.ulongButton.UseVisualStyleBackColor = true;
            this.ulongButton.Click += new System.EventHandler(this.ulongButton_Click);
            // 
            // longButton
            // 
            this.longButton.Location = new System.Drawing.Point(220, 60);
            this.longButton.Name = "longButton";
            this.longButton.Size = new System.Drawing.Size(80, 25);
            this.longButton.TabIndex = 6;
            this.longButton.Text = "long";
            this.longButton.UseVisualStyleBackColor = true;
            this.longButton.Click += new System.EventHandler(this.longButton_Click);
            // 
            // uintButton
            // 
            this.uintButton.Location = new System.Drawing.Point(120, 60);
            this.uintButton.Name = "uintButton";
            this.uintButton.Size = new System.Drawing.Size(80, 25);
            this.uintButton.TabIndex = 5;
            this.uintButton.Text = "uint";
            this.uintButton.UseVisualStyleBackColor = true;
            this.uintButton.Click += new System.EventHandler(this.uintButton_Click);
            // 
            // intButton
            // 
            this.intButton.Location = new System.Drawing.Point(20, 60);
            this.intButton.Name = "intButton";
            this.intButton.Size = new System.Drawing.Size(80, 25);
            this.intButton.TabIndex = 4;
            this.intButton.Text = "int";
            this.intButton.UseVisualStyleBackColor = true;
            this.intButton.Click += new System.EventHandler(this.intButton_Click);
            // 
            // TypeLimitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 101);
            this.Controls.Add(this.ulongButton);
            this.Controls.Add(this.longButton);
            this.Controls.Add(this.uintButton);
            this.Controls.Add(this.intButton);
            this.Controls.Add(this.ushortButton);
            this.Controls.Add(this.shortButton);
            this.Controls.Add(this.sbyteButton);
            this.Controls.Add(this.byteButton);
            this.Name = "TypeLimitsForm";
            this.Text = "TypeLimits";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button byteButton;
        private System.Windows.Forms.Button sbyteButton;
        private System.Windows.Forms.Button shortButton;
        private System.Windows.Forms.Button ushortButton;
        private System.Windows.Forms.Button ulongButton;
        private System.Windows.Forms.Button longButton;
        private System.Windows.Forms.Button uintButton;
        private System.Windows.Forms.Button intButton;
    }
}

