using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private static int value;
        private static bool flag;
        private static int counter;
        private static int memory;
        private void MakeNull() 
        {
            textBox1.Text = "";
            flag = true;
            counter = 0;
        }
        private bool CheckSigns() 
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Substring(0, 1) == "+" || textBox1.Text.Substring(0, 1) == "-" || textBox1.Text.Substring(0, 1) == "*" || textBox1.Text.Substring(0, 1) == "/" || textBox1.Text.Substring(0, 1) == "%" || textBox1.Text.Substring(0, 1) == "|")
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
        public Form1()
        {
            InitializeComponent();
            value = 0;
            flag = false;
            counter = 0;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void one_button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            flag = true;
            
        }
        private void two_button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            flag = true;
        }
        private void three_button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            flag = true;
        }
        private void four_button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            flag = true;
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            flag = true;
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            flag = true;
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            flag = true;
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            flag = true;
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            flag = true;
        }
        private void zero_button_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            flag = true;
        }
        private void memoryout_button_Click(object sender, EventArgs e)
        {
            textBox1.Text += memory;   
        }

        private void memoryin_button_Click(object sender, EventArgs e)
        {
            memory = value;
            memory = 0;
        }

        private void clean_button_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            flag = true;
            counter = 0;
        }

        private void multiply_button_Click(object sender, EventArgs e)
        {
            if (flag != false)
            {
                if (label1.Text.Length == 0)
                {
                    label1.Text = textBox1.Text;
                    textBox1.Text = "*";
                    flag = false;
                    counter++;
                }
                else if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "*";
                    flag = false;
                    counter++;
                }
            }
        }

        private void division_button_Click(object sender, EventArgs e)
        {
            if (flag != false)
            {
                if (label1.Text.Length == 0)
                {
                    label1.Text = textBox1.Text;
                    textBox1.Text = "/";
                    flag = false;
                    counter++;
                }
                else if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "/";
                    flag = false;
                    counter++;
                }
            }
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            if(flag!= false) 
            {
                if (label1.Text.Length == 0)
                {
                    label1.Text = textBox1.Text;
                    textBox1.Text = "+";
                    flag = false;
                    counter++;
                }
                else if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "+";
                    flag = false;
                    counter++;
                }
            }
        }
        private void minus_button_Click(object sender, EventArgs e)
        { 
            if(label1.Text.Length == 0 && textBox1.Text.Length == 0) 
            {
                textBox1.Text += "-";
                counter++;
                flag = false;
            }
                else if ((flag != false || CheckSigns())&& counter!=2 )
                {
                    if (label1.Text.Length == 0 )
                    {
                        label1.Text = textBox1.Text;
                        textBox1.Text = "-";
                        counter++; 
                        flag = false;
                    }
                    else if(textBox1.Text.Length < 2)
                    {
                        textBox1.Text += "-";
                        counter++;
                        flag = false;
                    }
                }
        }

        private void percent_button_Click(object sender, EventArgs e)
        {
            if (flag != false)
            {
                if (label1.Text.Length == 0)
                {
                    label1.Text = textBox1.Text;
                    textBox1.Text = "%";
                    flag = false;
                    counter++;
                }
                else if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "%";
                    flag = false;
                    counter++;
                }
            }
        }
        private void equal_button_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0 && CheckSigns()) 
            {
                if (textBox1.Text.Substring(1).Length > 0 && textBox1.Text.Substring(1)!="-") 
                {
                    string sign = textBox1.Text.Substring(0,1);
                    value = Convert.ToInt32(label1.Text);
                    switch (sign)
                    {
                        case "+": label1.Text = Convert.ToString(value +Convert.ToInt32(textBox1.Text.Substring(1)));
                            MakeNull();
                            break;
                        case "-":
                            label1.Text = Convert.ToString(value - Convert.ToInt32(textBox1.Text.Substring(1)));
                            MakeNull();
                            break;
                        case "*":
                            label1.Text = Convert.ToString(value * Convert.ToInt32(textBox1.Text.Substring(1)));
                            MakeNull();
                            break;
                        case "/":
                            label1.Text = Convert.ToString(value / Convert.ToInt32(textBox1.Text.Substring(1)));
                            MakeNull();
                            break;
                        case "%":
                            label1.Text = Convert.ToString(value %Convert.ToInt32(textBox1.Text.Substring(1)));
                            MakeNull();
                            break;
                    }   
                }
            }
            
        }
    }
}
