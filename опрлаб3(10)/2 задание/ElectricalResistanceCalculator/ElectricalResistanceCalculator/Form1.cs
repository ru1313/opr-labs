using System;
using System.Windows.Forms;

namespace ElectricalResistanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!seriesRadioButton.Checked && !parallelRadioButton.Checked)
                {
                    MessageBox.Show("Не выбран тип соединения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double resistance1 = double.Parse(resistance1TextBox.Text);
                double resistance2 = double.Parse(resistance2TextBox.Text);

                if (seriesRadioButton.Checked)
                {
                    double totalResistance = resistance1 + resistance2;
                    resultLabel.Text = "Сопротивление в последовательном соединении: " + totalResistance.ToString() + " Ом";
                }
                else if (parallelRadioButton.Checked)
                {
                    double totalResistance = 1 / (1 / resistance1 + 1 / resistance2);
                    resultLabel.Text = "Сопротивление в параллельном соединении: " + totalResistance.ToString() + " Ом";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите числовые значения сопротивлений.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


