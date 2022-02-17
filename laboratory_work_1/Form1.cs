using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratory_work_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, b, am, gm, c;

       

        private void btn2_1_11_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(tb1_1_11.Text);
                b = Convert.ToDouble(tb2_1_11.Text);
                am = (a + b);
                gm = Math.Round(Math.Sqrt(a * b),1);
                tb3_1_11.Text = Convert.ToString(am);
                tb4_1_11.Text = Convert.ToString(gm);
                l5_1_11.Text = null;
            }
            catch (FormatException)
            {
                l5_1_11.Text = "Упс, что-то не так , проверьте введеное значение.";
            }
        }

        private void btn1_1_11_Click(object sender, EventArgs e)
        {
            tb1_1_11.Clear();
            tb2_1_11.Clear();
            tb3_1_11.Clear();
            tb4_1_11.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(tb1_1_12.Text);
                b = Convert.ToDouble(tb2_1_12.Text);
                c = Math.Round(Math.Sqrt((a * a) + (b * b)),1);
                tb3_1_12.Text = Convert.ToString(c);
                l4_1_12.Text = null;
            }
            catch (FormatException)
            {
                l4_1_12.Text = "Упс, что-то не так , проверьте введеное значение.";
            }
        }

        private void btn2_1_12_Click(object sender, EventArgs e)
        {
            tb1_1_12.Clear();
            tb2_1_12.Clear();
            tb3_1_12.Clear();
        }
    }
}
