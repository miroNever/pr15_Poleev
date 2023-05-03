using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_15
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            /*            ComplexNumbers Vaild = new ComplexNumbers();
                        ComplexNumbers Imaginary = new ComplexNumbers();
                        Vaild.Vaild = Convert.ToDouble(textBox1.Text);
                        Vaild.Vaild = Convert.ToDouble(textBox3.Text);
                        Imaginary.Imaginary = Convert.ToDouble(textBox2.Text);
                        Imaginary.Imaginary = Convert.ToDouble(textBox4.Text);
                        if (Sum.Checked)
                        {
                            MessageBox.Show($"Результат сложения ");
                        }
                        else if (Dif.Checked)
                        {
                            MessageBox.Show($"Результат вычитания ");
                        }
                        else if (Mul.Checked)
                        {
                            MessageBox.Show($"Результат умножения ");
                        }*/
            try
            {
                string res = "";
                double r1 = double.Parse(textBox1.Text);
                double r2 = double.Parse(textBox3.Text);
                double i1 = double.Parse(textBox2.Text);
                double i2 = double.Parse(textBox4.Text);
                ComplexNumbers num1 = new ComplexNumbers(r1, i1);
                ComplexNumbers num2 = new ComplexNumbers(r2, i2);
                if (Sum.Checked)
                {
                    res = num1.Add(num2).ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
