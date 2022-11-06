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

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.label1.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";
            if (this.label1.Text != "")
            {
                this.Operation_label.Text = this.label1.Text;
            }
            this.label1.Text = "";
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-";
            if (this.label1.Text != "")
            {
                this.Operation_label.Text = this.label1.Text;
            }
            this.label1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "x";
            if (this.label1.Text != "")
            {
                this.Operation_label.Text = this.label1.Text;
            }
            this.label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "%";
            if (this.label1.Text != "")
            {
                this.Operation_label.Text = this.label1.Text;
            }
            this.label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;
            double Result;
            //-----------------------------------------------------------------------
            double.TryParse(this.Operation_label.Text, out firstNumber);    
            double.TryParse(this.label1.Text, out secondNumber);
            Result = 0;
            //-----------------------------------------------------------------------
            if (this.operator_label.Text == "+")
            {
                Result = firstNumber + secondNumber;
            }
            //-----------------------------------------------------------------------
            if (this.operator_label.Text == "-")
            {
                Result = firstNumber - secondNumber;
            }
            //-----------------------------------------------------------------------
            if (this.operator_label.Text == "x")
            {
                Result = firstNumber * secondNumber;
            }
            //-----------------------------------------------------------------------
            if (this.operator_label.Text == "%")
            {
                Result = firstNumber / secondNumber;
            }
            this.label1.Text = Result.ToString();
            this.operator_label.Text = "";
            this.Operation_label.ResetText();
            
        }
    }
}
