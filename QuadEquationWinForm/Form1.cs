using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadEquationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);            
            int b = int.Parse(textBox2.Text);            
            int c = int.Parse(textBox3.Text);                       
            textBox5.Visible = false;
            textBox6.Visible = false;
            double D;
            D = b * b - 4 * a * c;
            if (D > 0)
            {
                textBox5.Visible = true;
                textBox6.Visible = true;
                double x1, x2;
                x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
                textBox5.Text = x1.ToString();
                textBox6.Text = x2.ToString();
            }
            else if (D == 0)
            {
                textBox5.Visible = true;
                label6.Visible = false;
                double x;
                x = (-b) / (2 * a);
                textBox5.Text = x.ToString();
            }
            else
            {
                label5.Visible = false;
                label6.Visible = false;
                MessageBox.Show("Решений не существует.");
            }
        }
    }
}
