using System;
using System.Globalization;
using System.Windows.Forms;
using DlsCalculation_.Services;

namespace DlsCalculation_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(Incl1.Text, out double f1);
            double.TryParse(Incl2.Text, out double f2);
            double.TryParse(Azm1.Text, out double v1);
            double.TryParse(Azm2.Text, out double v2);
            double.TryParse(Md1.Text, out double s1);
            double.TryParse(Md2.Text, out double s2);

            Result.Text = Calculator.DlsResult(f1, f2, v1, v2, s1, s2).ToString(CultureInfo.InvariantCulture);
        }

        private void InputProtection(KeyPressEventArgs e)
        {
            var number = e.KeyChar;

            if (!char.IsDigit(number) && number != 8 && number != 46)
            {
                e.Handled = true;
            }
        }

        private void Incl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputProtection(e);
        }

        private void Azm1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputProtection(e);
        }

        private void Md1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputProtection(e);
        }

        private void Incl2_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputProtection(e);
        }

        private void Azm2_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputProtection(e);
        }

        private void Md2_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputProtection(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Incl1.Text = @"0";
            Incl2.Text = @"0";
            Azm1.Text = @"0";
            Azm2.Text = @"0";
            Md1.Text = @"0";
            Md2.Text = @"0";
            Result.Text = @"0.00";
        }
    }
}
