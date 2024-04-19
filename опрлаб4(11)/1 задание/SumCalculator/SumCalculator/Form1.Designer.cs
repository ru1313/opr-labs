namespace SumCalculator
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
            this.scrollBar = new System.Windows.Forms.VScrollBar();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumFormulaLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scrollBar
            // 
            this.scrollBar.Location = new System.Drawing.Point(9, 9);
            this.scrollBar.Maximum = 100;
            this.scrollBar.Minimum = 1;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(17, 183);
            this.scrollBar.TabIndex = 0;
            this.scrollBar.Value = 1;
            this.scrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBar_Scroll);
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(32, 9);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(46, 15);
            this.sumLabel.TabIndex = 1;
            this.sumLabel.Text = "Сумма:";
            // 
            // sumFormulaLabel
            // 
            this.sumFormulaLabel.AutoSize = true;
            this.sumFormulaLabel.Location = new System.Drawing.Point(32, 42);
            this.sumFormulaLabel.Name = "sumFormulaLabel";
            this.sumFormulaLabel.Size = new System.Drawing.Size(99, 15);
            this.sumFormulaLabel.TabIndex = 2;
            this.sumFormulaLabel.Text = "Сумма (формула):";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(32, 76);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(0, 15);
            this.nLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.sumFormulaLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.scrollBar);
            this.Name = "Form1";
            this.Text = "Сумма последовательности";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.VScrollBar scrollBar;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label sumFormulaLabel;
        private System.Windows.Forms.Label nLabel;
    }
}

