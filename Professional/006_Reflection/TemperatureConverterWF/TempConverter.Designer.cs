namespace TemperatureConverterWF
{
    partial class TempConverter
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
            this.CelsiusTextBox = new System.Windows.Forms.TextBox();
            this.FahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.Celsius_Label = new System.Windows.Forms.Label();
            this.FahrenheitLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CelsiusTextBox
            // 
            this.CelsiusTextBox.Location = new System.Drawing.Point(12, 25);
            this.CelsiusTextBox.Name = "CelsiusTextBox";
            this.CelsiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.CelsiusTextBox.TabIndex = 0;
            this.CelsiusTextBox.TextChanged += new System.EventHandler(this.InputControllerOnTextChanged);
            // 
            // FahrenheitTextBox
            // 
            this.FahrenheitTextBox.Location = new System.Drawing.Point(161, 25);
            this.FahrenheitTextBox.Name = "FahrenheitTextBox";
            this.FahrenheitTextBox.ReadOnly = true;
            this.FahrenheitTextBox.Size = new System.Drawing.Size(100, 20);
            this.FahrenheitTextBox.TabIndex = 1;
            // 
            // Celsius_Label
            // 
            this.Celsius_Label.AutoSize = true;
            this.Celsius_Label.Location = new System.Drawing.Point(12, 9);
            this.Celsius_Label.Name = "Celsius_Label";
            this.Celsius_Label.Size = new System.Drawing.Size(40, 13);
            this.Celsius_Label.TabIndex = 2;
            this.Celsius_Label.Text = "Celsius";
            // 
            // FahrenheitLabel
            // 
            this.FahrenheitLabel.AutoSize = true;
            this.FahrenheitLabel.Location = new System.Drawing.Point(161, 9);
            this.FahrenheitLabel.Name = "FahrenheitLabel";
            this.FahrenheitLabel.Size = new System.Drawing.Size(57, 13);
            this.FahrenheitLabel.TabIndex = 3;
            this.FahrenheitLabel.Text = "Fahrenheit";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(118, 22);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(37, 23);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "->";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // TempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 54);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.FahrenheitLabel);
            this.Controls.Add(this.Celsius_Label);
            this.Controls.Add(this.FahrenheitTextBox);
            this.Controls.Add(this.CelsiusTextBox);
            this.Name = "TempConverter";
            this.Text = "TempConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CelsiusTextBox;
        private System.Windows.Forms.TextBox FahrenheitTextBox;
        private System.Windows.Forms.Label Celsius_Label;
        private System.Windows.Forms.Label FahrenheitLabel;
        private System.Windows.Forms.Button ConvertButton;
    }
}

