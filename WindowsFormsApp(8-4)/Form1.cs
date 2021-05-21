using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_8_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;
            int Number1 = Convert.ToInt32(textBox1.Text);
            int Number2 = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                result = Number1 % Number2;
                textBox3.Text = Convert.ToString(result);
            }
            else if (radioButton2.Checked == true)
            {
                result = Math.Pow(Number1, Number2);
                textBox3.Text = Convert.ToString(result);
            }
            else if (radioButton3.Checked == true)
            {
                textBox3.Text = textBox1.Text + textBox2.Text;
            }
            else if (radioButton4.Checked == true)
            {
                if (Number2 > 0)
                {
                    result = Number1 / Number2;
                    textBox3.Text = Convert.ToString(result);

                }
                else
                    textBox3.Text = "На ноль делить нельзя";
            }
            else
            {
                textBox3.Text = "Не выбрана ни одна операция";
            }
        }
    }
}
