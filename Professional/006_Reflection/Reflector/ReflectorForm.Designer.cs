namespace Reflector
{
    partial class ReflectorForm
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
            this.openFileLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CtorCheckBox = new System.Windows.Forms.CheckBox();
            this.PropertiesCheckBox = new System.Windows.Forms.CheckBox();
            this.EventsCheckBox = new System.Windows.Forms.CheckBox();
            this.FieldsCheckBox = new System.Windows.Forms.CheckBox();
            this.MethodsCheckBox = new System.Windows.Forms.CheckBox();
            this.NestedCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckBoxLabel = new System.Windows.Forms.Label();
            this.AttributesCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(12, 25);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(776, 20);
            this.PathBox.TabIndex = 0;
            this.PathBox.Click += new System.EventHandler(this.OpenFileEvent);
            // 
            // openFileLabel
            // 
            this.openFileLabel.AutoSize = true;
            this.openFileLabel.Location = new System.Drawing.Point(12, 9);
            this.openFileLabel.Name = "openFileLabel";
            this.openFileLabel.Size = new System.Drawing.Size(49, 13);
            this.openFileLabel.TabIndex = 1;
            this.openFileLabel.Text = "Open file";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 73);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(776, 365);
            this.textBox.TabIndex = 2;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Location = new System.Drawing.Point(763, 57);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(25, 13);
            this.textBoxLabel.TabIndex = 3;
            this.textBoxLabel.Text = "Info";
            // 
            // CtorCheckBox
            // 
            this.CtorCheckBox.AutoSize = true;
            this.CtorCheckBox.Checked = true;
            this.CtorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CtorCheckBox.Location = new System.Drawing.Point(61, 50);
            this.CtorCheckBox.Name = "CtorCheckBox";
            this.CtorCheckBox.Size = new System.Drawing.Size(85, 17);
            this.CtorCheckBox.TabIndex = 4;
            this.CtorCheckBox.Text = "Constructors";
            this.CtorCheckBox.UseVisualStyleBackColor = true;
            this.CtorCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // PropertiesCheckBox
            // 
            this.PropertiesCheckBox.AutoSize = true;
            this.PropertiesCheckBox.Checked = true;
            this.PropertiesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PropertiesCheckBox.Location = new System.Drawing.Point(152, 50);
            this.PropertiesCheckBox.Name = "PropertiesCheckBox";
            this.PropertiesCheckBox.Size = new System.Drawing.Size(73, 17);
            this.PropertiesCheckBox.TabIndex = 5;
            this.PropertiesCheckBox.Text = "Properties";
            this.PropertiesCheckBox.UseVisualStyleBackColor = true;
            this.PropertiesCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // EventsCheckBox
            // 
            this.EventsCheckBox.AutoSize = true;
            this.EventsCheckBox.Checked = true;
            this.EventsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EventsCheckBox.Location = new System.Drawing.Point(231, 50);
            this.EventsCheckBox.Name = "EventsCheckBox";
            this.EventsCheckBox.Size = new System.Drawing.Size(59, 17);
            this.EventsCheckBox.TabIndex = 6;
            this.EventsCheckBox.Text = "Events";
            this.EventsCheckBox.UseVisualStyleBackColor = true;
            this.EventsCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // FieldsCheckBox
            // 
            this.FieldsCheckBox.AutoSize = true;
            this.FieldsCheckBox.Checked = true;
            this.FieldsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FieldsCheckBox.Location = new System.Drawing.Point(296, 50);
            this.FieldsCheckBox.Name = "FieldsCheckBox";
            this.FieldsCheckBox.Size = new System.Drawing.Size(53, 17);
            this.FieldsCheckBox.TabIndex = 7;
            this.FieldsCheckBox.Text = "Fields";
            this.FieldsCheckBox.UseVisualStyleBackColor = true;
            this.FieldsCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // MethodsCheckBox
            // 
            this.MethodsCheckBox.AutoSize = true;
            this.MethodsCheckBox.Checked = true;
            this.MethodsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MethodsCheckBox.Location = new System.Drawing.Point(355, 50);
            this.MethodsCheckBox.Name = "MethodsCheckBox";
            this.MethodsCheckBox.Size = new System.Drawing.Size(67, 17);
            this.MethodsCheckBox.TabIndex = 8;
            this.MethodsCheckBox.Text = "Methods";
            this.MethodsCheckBox.UseVisualStyleBackColor = true;
            this.MethodsCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // NestedCheckBox
            // 
            this.NestedCheckBox.AutoSize = true;
            this.NestedCheckBox.Checked = true;
            this.NestedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NestedCheckBox.Location = new System.Drawing.Point(428, 50);
            this.NestedCheckBox.Name = "NestedCheckBox";
            this.NestedCheckBox.Size = new System.Drawing.Size(92, 17);
            this.NestedCheckBox.TabIndex = 9;
            this.NestedCheckBox.Text = "Nested Types";
            this.NestedCheckBox.UseVisualStyleBackColor = true;
            this.NestedCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // CheckBoxLabel
            // 
            this.CheckBoxLabel.AutoSize = true;
            this.CheckBoxLabel.Location = new System.Drawing.Point(12, 51);
            this.CheckBoxLabel.Name = "CheckBoxLabel";
            this.CheckBoxLabel.Size = new System.Drawing.Size(43, 13);
            this.CheckBoxLabel.TabIndex = 10;
            this.CheckBoxLabel.Text = "Show : ";
            // 
            // AttributesCheckBox
            // 
            this.AttributesCheckBox.AutoSize = true;
            this.AttributesCheckBox.Checked = true;
            this.AttributesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AttributesCheckBox.Location = new System.Drawing.Point(526, 50);
            this.AttributesCheckBox.Name = "AttributesCheckBox";
            this.AttributesCheckBox.Size = new System.Drawing.Size(70, 17);
            this.AttributesCheckBox.TabIndex = 11;
            this.AttributesCheckBox.Text = "Attributes";
            this.AttributesCheckBox.UseVisualStyleBackColor = true;
            this.AttributesCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // ReflectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AttributesCheckBox);
            this.Controls.Add(this.CheckBoxLabel);
            this.Controls.Add(this.NestedCheckBox);
            this.Controls.Add(this.MethodsCheckBox);
            this.Controls.Add(this.FieldsCheckBox);
            this.Controls.Add(this.EventsCheckBox);
            this.Controls.Add(this.PropertiesCheckBox);
            this.Controls.Add(this.CtorCheckBox);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.openFileLabel);
            this.Controls.Add(this.PathBox);
            this.Name = "ReflectorForm";
            this.Text = "Reflector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label openFileLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox CtorCheckBox;
        private System.Windows.Forms.CheckBox PropertiesCheckBox;
        private System.Windows.Forms.CheckBox EventsCheckBox;
        private System.Windows.Forms.CheckBox FieldsCheckBox;
        private System.Windows.Forms.CheckBox MethodsCheckBox;
        private System.Windows.Forms.CheckBox NestedCheckBox;
        private System.Windows.Forms.Label CheckBoxLabel;
        private System.Windows.Forms.CheckBox AttributesCheckBox;
    }
}

