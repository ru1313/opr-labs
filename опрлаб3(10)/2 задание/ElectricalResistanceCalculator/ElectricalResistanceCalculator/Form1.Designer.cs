namespace ElectricalResistanceCalculator
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
            this.resistance1Label = new System.Windows.Forms.Label();
            this.resistance2Label = new System.Windows.Forms.Label();
            this.resistance1TextBox = new System.Windows.Forms.TextBox();
            this.resistance2TextBox = new System.Windows.Forms.TextBox();
            this.seriesRadioButton = new System.Windows.Forms.RadioButton();
            this.parallelRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resistance1Label
            // 
            this.resistance1Label.AutoSize = true;
            this.resistance1Label.Location = new System.Drawing.Point(31, 28);
            this.resistance1Label.Name = "resistance1Label";
            this.resistance1Label.Size = new System.Drawing.Size(103, 15);
            this.resistance1Label.TabIndex = 0;
            this.resistance1Label.Text = "Сопротивление 1:";
            // 
            // resistance2Label
            // 
            this.resistance2Label.AutoSize = true;
            this.resistance2Label.Location = new System.Drawing.Point(31, 63);
            this.resistance2Label.Name = "resistance2Label";
            this.resistance2Label.Size = new System.Drawing.Size(103, 15);
            this.resistance2Label.TabIndex = 1;
            this.resistance2Label.Text = "Сопротивление 2:";
            // 
            // resistance1TextBox
            // 
            this.resistance1TextBox.Location = new System.Drawing.Point(140, 25);
            this.resistance1TextBox.Name = "resistance1TextBox";
            this.resistance1TextBox.Size = new System.Drawing.Size(100, 23);
            this.resistance1TextBox.TabIndex = 2;
            // 
            // resistance2TextBox
            // 
            this.resistance2TextBox.Location = new System.Drawing.Point(140, 60);
            this.resistance2TextBox.Name = "resistance2TextBox";
            this.resistance2TextBox.Size = new System.Drawing.Size(100, 23);
            this.resistance2TextBox.TabIndex = 3;
            // 
            // seriesRadioButton
            // 
            this.seriesRadioButton.AutoSize = true;
            this.seriesRadioButton.Location = new System.Drawing.Point(34, 108);
            this.seriesRadioButton.Name = "seriesRadioButton";
            this.seriesRadioButton.Size = new System.Drawing.Size(140, 19);
            this.seriesRadioButton.TabIndex = 4;
            this.seriesRadioButton.TabStop = true;
            this.seriesRadioButton.Text = "Последовательное";
            this.seriesRadioButton.UseVisualStyleBackColor = true;
            // 
            // parallelRadioButton
            // 
            this.parallelRadioButton.AutoSize = true;
            this.parallelRadioButton.Location = new System.Drawing.Point(34, 133);
            this.parallelRadioButton.Name = "parallelRadioButton";
            this.parallelRadioButton.Size = new System.Drawing.Size(88, 19);
            this.parallelRadioButton.TabIndex = 5;
            this.parallelRadioButton.TabStop = true;
            this.parallelRadioButton.Text = "Параллельное";
            this.parallelRadioButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(34, 170);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(206, 31);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(31, 218);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 15);
            this.resultLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.parallelRadioButton);
            this.Controls.Add(this.seriesRadioButton);
            this.Controls.Add(this.resistance2TextBox);
            this.Controls.Add(this.resistance1TextBox);
            this.Controls.Add(this.resistance2Label);
            this.Controls.Add(this.resistance1Label);
            this.Name = "Form1";
            this.Text = "Калькулятор сопротивления";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label resistance1Label;
        private System.Windows.Forms.Label resistance2Label;
        private System.Windows.Forms.TextBox resistance1TextBox;
        private System.Windows.Forms.TextBox resistance2TextBox;
        private System.Windows.Forms.RadioButton seriesRadioButton;
        private System.Windows.Forms.RadioButton parallelRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

