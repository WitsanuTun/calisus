using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calisus
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        float result;
        string opt;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
            
        {
            label1.Text += "0";
        }

        private void bc_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            label2.Text = string.Empty;
        }

        private void bltlt_Click(object sender, EventArgs e)
        {
            string word = label1.Text;
            label1.Text = word.Remove(word.Length - 1);
        }

        private void bp_Click(object sender, EventArgs e)
        {
            label2.Text = label1.Text +" + ";
            label1.Text = string.Empty;
        }

        private void bl_Click(object sender, EventArgs e)
        {
            label2.Text = label1.Text + " - ";
            label1.Text = string.Empty;
        }

        private void bk_Click(object sender, EventArgs e)
        {
            label2.Text = label1.Text + " X ";
            label1.Text = string.Empty;
        }

        private void bh_Click(object sender, EventArgs e)
        {
            label2.Text = label1.Text + " / ";
            label1.Text = string.Empty;
        }

        private void btk_Click(object sender, EventArgs e)
        {
            label2.Text += label1.Text + " = ";
            string[] word = label2.Text.Split(' ');
            num1 = Convert.ToInt32(word[0]);
            num2 = Convert.ToInt32(word[2]);
            opt = word[1];
            switch (opt)
            {
                case "+": result = (float)num1 + (float)num2; break;
                case "-": result = (float)num1 - (float)num2; break;
                case "*": result = (float)num1 * (float)num2; break;
                case "/": result = (float)num1 / (float)num2; break;
                case "^": result = (float)Math.Pow(num1, num2); break;
                case "√": result = (float)Math.Pow(num1, num2); break;
            }
            label1.Text = result.ToString();
        }

        private void bpow_Click(object sender, EventArgs e)
        {
            label2.Text = label1.Text + " ^ ";
            label1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "√";
            label2.Text = label1.Text + " √ ";
            label1.Text = string.Empty;
        }
    }
}
