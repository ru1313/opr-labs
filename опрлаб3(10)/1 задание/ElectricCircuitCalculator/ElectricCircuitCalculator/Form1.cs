using System;
using System.Windows.Forms;

namespace ElectricCircuitCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double voltage = Convert.ToDouble(txtVoltage.Text);
                double resistance = Convert.ToDouble(txtResistance.Text);

                if (resistance == 0)
                {
                    MessageBox.Show("Сопротивление не может быть равным нулю.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double current = voltage / resistance;

                MessageBox.Show("Сила тока: " + current.ToString() + " А");
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtResistance_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResistance.Text))
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }
    }
}


