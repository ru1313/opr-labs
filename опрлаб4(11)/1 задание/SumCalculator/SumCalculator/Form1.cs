using System;
using System.Windows.Forms;

namespace SumCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int n = scrollBar.Value;
            int sum = CalculateSumLoop(n); // Вычисление суммы в цикле
            int sumFormula = CalculateSumFormula(n); // Вычисление суммы по формуле

            // Отображение результатов
            sumLabel.Text = "Сумма (цикл): " + sum.ToString();
            sumFormulaLabel.Text = "Сумма (формула): " + sumFormula.ToString();
            nLabel.Text = "n = " + n.ToString();
        }

        private int CalculateSumLoop(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        private int CalculateSumFormula(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}
