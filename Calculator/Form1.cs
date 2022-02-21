using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double FirstNumber;
        string Operation;



       

       

        private void btn10_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt1.Text);
            txt1.Text = "0";
            Operation = "-";
        }

       

        private void btn1_Click_1(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "1";
            }
            else
            {
                txt1.Text = txt1.Text + "1";
            }
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "2";
            }
            else
            {
                txt1.Text = txt1.Text + "2";
            }
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "3";
            }
            else
            {
                txt1.Text = txt1.Text + "3";
            }
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "4";
            }
            else
            {
                txt1.Text = txt1.Text + "4";
            }
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "5";
            }
            else
            {
                txt1.Text = txt1.Text + "5";
            }
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "6";
            }
            else
            {
                txt1.Text = txt1.Text + "6";
            }
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "7";
            }
            else
            {
                txt1.Text = txt1.Text + "7";
            }
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "8";
            }
            else
            {
                txt1.Text = txt1.Text + "8";
            }
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = "9";
            }
            else
            {
                txt1.Text = txt1.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "0";
        }

        private void btn11_Click_1(object sender, EventArgs e)
        {
           
                FirstNumber = Convert.ToDouble(txt1.Text);
                txt1.Text = " ";
                Operation = "+";
            
            
        }

        private void btn12_Click_1(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt1.Text);
            txt1.Text = " ";
            Operation = "*";
        }

        private void btn13_Click_1(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txt1.Text);
            txt1.Text = " ";
            Operation = "/";
        }

        private void btn14_Click_1(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;
            string[] a = txt1.Text.Split('+' ,'-','*','/');


            
            SecondNumber = Convert.ToDouble(txt1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                txt1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                txt1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                txt1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txt1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    txt1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }
            


        private void btnc_Click(object sender, EventArgs e)
        {
            txt1.Clear();
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "0" && txt1.Text != null)
            {
                txt1.Text = ".";
            }
            else
            {
                txt1.Text = txt1.Text + ".";
            }
            
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txt1.Text != string.Empty)
            {
                int txtlength = txt1.Text.Length;
                if (txtlength != 1)
                {
                    txt1.Text = txt1.Text.Remove(txtlength - 1);
                }
                else
                {
                    txt1.Text = 0.ToString();
                }
            }
        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            txt1.Text = new DataTable().Compute(txt1.Text, "") + "";
        }
    }
}
