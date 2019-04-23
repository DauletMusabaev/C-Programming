using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        Double res = 0;
        String oprPerformed = "";
        bool isOprPfmd = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            button1.Text = "7";
            button2.Text = "8";
            button3.Text = "9";
            button4.Text = "/";
            button5.Text = "*";
            button6.Text = "6";
            button7.Text = "5";
            button8.Text = "4";
            button9.Text = "+";
            button10.Text = "3";
            button11.Text = "2";
            button12.Text = "1";
            button13.Text = "-";
            button14.Text = ".";
            button15.Text = "0";
            button16.Text = "c";
            button17.Text = "CE";
            button18.Text = "C";
            button19.Text = "=";
            /*
            dynamically create buttons
            List<Button> buttons = new List<Button>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 25);
                    buttons.Add(btn);
                    btn.Location = new Point(i * 50, j * 25);
                    this.Controls.Add(btn);
                }
            }
            */
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" || isOprPfmd)
                textBoxResult.Clear();
            isOprPfmd = false;
            Button btn = sender as Button;
            if(btn.Text == ".")
            {
                if (!textBoxResult.Text.Contains("."))
                    textBoxResult.Text = textBoxResult.Text + btn.Text;
            }
            else
                textBoxResult.Text = textBoxResult.Text + btn.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (res != 0)
            { 
                button19.PerformClick();
                oprPerformed = btn.Text;
                label1.Text = res + " " + oprPerformed;
                isOprPfmd = true;
            }
            else
            {
                oprPerformed = btn.Text;
                res = Double.Parse(textBoxResult.Text);
                label1.Text = res + " " + oprPerformed;
                isOprPfmd = true;

            }
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            res = 0;
        }

        private void equaliz(object sender, EventArgs e)
        {
            switch (oprPerformed)
            {
                case "+":
                    textBoxResult.Text = (res + Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (res - Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (res * Double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (res / Double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            res = Double.Parse(textBoxResult.Text);
            label1.Text = "";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
