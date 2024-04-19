namespace ElectricCircuitCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtVoltage;
        private System.Windows.Forms.TextBox txtResistance;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.Label lblResistance;

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
            this.txtVoltage = new System.Windows.Forms.TextBox();
            this.txtResistance = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.lblResistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVoltage
            // 
            this.txtVoltage.Location = new System.Drawing.Point(52, 30);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.Size = new System.Drawing.Size(100, 20);
            this.txtVoltage.TabIndex = 0;
            // 
            // txtResistance
            // 
            this.txtResistance.Location = new System.Drawing.Point(52, 70);
            this.txtResistance.Name = "txtResistance";
            this.txtResistance.Size = new System.Drawing.Size(100, 20);
            this.txtResistance.TabIndex = 1;
            this.txtResistance.TextChanged += new System.EventHandler(this.txtResistance_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(52, 110);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblVoltage
            // 
            this.lblVoltage.AutoSize = true;
            this.lblVoltage.Location = new System.Drawing.Point(52, 10);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(91, 13);
            this.lblVoltage.TabIndex = 3;
            this.lblVoltage.Text = "Напряжение (В):";
            // 
            // lblResistance
            // 
            this.lblResistance.AutoSize = true;
            this.lblResistance.Location = new System.Drawing.Point(52, 50);
            this.lblResistance.Name = "lblResistance";
            this.lblResistance.Size = new System.Drawing.Size(102, 13);
            this.lblResistance.TabIndex = 4;
            this.lblResistance.Text = "Сопротивление (Ω):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 168);
            this.Controls.Add(this.lblResistance);
            this.Controls.Add(this.lblVoltage);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResistance);
            this.Controls.Add(this.txtVoltage);
            this.Name = "Form1";
            this.Text = "Electric Circuit Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
