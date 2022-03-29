using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFirstPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label_B_Click(object sender, EventArgs e)
        {

        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            // Contain coefficients
            float a, b, c;
            // Contain solution
            float _x_1, _x_2;

            if (!float.TryParse(a_coeff.Text, out a) || !float.TryParse(b_coeff.Text, out b) || !float.TryParse(c_coeff.Text, out c))
            {
                throw new ArgumentException(message: "Can't parse input values");
            }

            if (Math.Abs(a) < 1.0e-8)
            {
                _x_1 = _x_2 = c / b;
                _x_1.ToString();
                _x_2.ToString();
                return;
            } 
            else if (Math.Abs(Math.Sqrt(b * b - 4 * a * c)) < 1.0e-8)
            {
                _x_1 = (-b + (float)Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                _x_2 = (-b - (float)Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Solution.Text = String.Format("x1 = {0}, x2 = {1}", _x_1.ToString(), _x_2.ToString());
                return;
            } 
            else if ((b * b - 4 * a * c) < 0)
            {
                Solution.Text = String.Format("No solution in real numbers");
                return;
            }
            _x_1 = (-b + (float)Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            _x_2 = (-b - (float)Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Solution.Text = String.Format("x1 = {0}, x2 = {1}", _x_1.ToString(), _x_2.ToString());
        }

        private void c_coeff_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
