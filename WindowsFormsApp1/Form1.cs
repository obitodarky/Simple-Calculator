using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double ans = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operation_pressed) {
                textBox1.Clear();
            }

            Button b = (Button)sender;

            textBox1.Text = textBox1.Text + b.Text;


        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            operation = b.Text;
            ans = Double.Parse(textBox1.Text);
            operation_pressed = true;
            label1.Text = ans + " " + operation;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (operation) {

                case "+":
                    textBox1.Text = (ans + Double.Parse(textBox1.Text)).ToString(); 
                    break;
                case "-":
                    textBox1.Text = (ans - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (ans * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (ans / Double.Parse(textBox1.Text)).ToString();
                    break;

            }
            operation_pressed = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            ans = 0;
        }
    }
}
