using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                private void button1_Click(object sender, EventArgs e)
        {
            double sum;
            int period;
            double percent;
            double profit;
            double taxes;
            double paying_taxes;
            sum = System.Convert.ToDouble(textBox1.Text);
            period = System.Convert.ToInt32(textBox2.Text);
            if (sum < 10000)
                percent = 3.5;
            else
                percent = 4.5;
            profit = sum * (percent / 100 / 12) * period;
            taxes = (sum * period);
            paying_taxes = (sum * 0.13);
            label3.Text =
            "Процентная ставка: " + percent.ToString("n") + "%\n" +
            "Доход: " + profit.ToString("c");

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
