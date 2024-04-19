namespace StudentRecords
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            generateButton = new System.Windows.Forms.Button();
            readButton = new System.Windows.Forms.Button();
            studentsListBox = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // generateButton
            // 
            generateButton.Location = new System.Drawing.Point(12, 12);
            generateButton.Name = "generateButton";
            generateButton.Size = new System.Drawing.Size(150, 30);
            generateButton.TabIndex = 0;
            generateButton.Text = "Сгенерировать и записать";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += GenerateButton_Click;
            // 
            // readButton
            // 
            readButton.Location = new System.Drawing.Point(12, 48);
            readButton.Name = "readButton";
            readButton.Size = new System.Drawing.Size(150, 30);
            readButton.TabIndex = 1;
            readButton.Text = "Прочитать и вывести";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += ReadButton_Click;
            // 
            // studentsListBox
            // 
            studentsListBox.FormattingEnabled = true;
            studentsListBox.HorizontalScrollbar = true;
            studentsListBox.ItemHeight = 15;
            studentsListBox.Location = new System.Drawing.Point(180, 12);
            studentsListBox.Name = "studentsListBox";
            studentsListBox.Size = new System.Drawing.Size(400, 169);
            studentsListBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(600, 260);
            Controls.Add(studentsListBox);
            Controls.Add(readButton);
            Controls.Add(generateButton);
            Name = "Form1";
            Text = "Student Records";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.ListBox studentsListBox;
    }
}
