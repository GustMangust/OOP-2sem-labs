using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1dop
{
    public partial class Form1 : Form
    {
        public static int counter = 0;
        public static bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void American_Click(object sender, EventArgs e)
        {

                if (ClothesText.Text.Length > 0 && ClothesText.Text.Length < 4 && Convert.ToInt32(ClothesText.Text) > 169 && Convert.ToInt32(ClothesText.Text) < 196)
                {
                    if (Convert.ToInt32(ClothesText.Text) < 180)
                    {
                        ClothesLabel.Text = "S";
                    }
                    if (Convert.ToInt32(ClothesText.Text) > 179 && Convert.ToInt32(ClothesText.Text) < 184)
                    {
                        ClothesLabel.Text = "M";
                    }
                    if (Convert.ToInt32(ClothesText.Text) > 179 && Convert.ToInt32(ClothesText.Text) < 184)
                    {
                        ClothesLabel.Text = "L";
                    }
                    if (Convert.ToInt32(ClothesText.Text) > 183 && Convert.ToInt32(ClothesText.Text) < 188)
                    {
                        ClothesLabel.Text = "XL";
                    }
                    if (Convert.ToInt32(ClothesText.Text) > 188)
                    {
                        ClothesLabel.Text = "XXL";
                    }
                }
                else ClothesLabel.Text = "Error";
            if (ShoesText.Text.Length > 0 && ShoesText.Text.Length < 4 && Convert.ToInt32(ShoesText.Text) > 22 && Convert.ToInt32(ShoesText.Text) < 31)
            {
                if (Convert.ToInt32(ShoesText.Text) == 23)
                {
                    ShoesLabel.Text = "7.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 24)
                {
                    ShoesLabel.Text = "8";
                }
                if (Convert.ToInt32(ShoesText.Text) == 25)
                {
                    ShoesLabel.Text = "9";
                }
                if (Convert.ToInt32(ShoesText.Text) == 26)
                {
                    ShoesLabel.Text = "9.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 27)
                {
                    ShoesLabel.Text = "10";
                }
                if (Convert.ToInt32(ShoesText.Text) == 28)
                {
                    ShoesLabel.Text = "11";
                }
                if (Convert.ToInt32(ShoesText.Text) == 29)
                {
                    ShoesLabel.Text = "12";
                }
                if (Convert.ToInt32(ShoesText.Text) == 30)
                {
                    ShoesLabel.Text = "12.5";
                }
            }
            else ShoesLabel.Text = "Error";
            flag = false;
            ErrorLabel.Text = "";
            counter = 0;
        }

        private void Belarussian_Click(object sender, EventArgs e)
        {
            if(counter == 0) 
            {
                flag = true;
            }
            if (flag == true)
            {
                counter++;
            }
            else counter = 0;
            if(counter == 3) 
            {
                ErrorLabel.Text = "понял, переключаю вас на оператора";
                counter = 0;
            }
            if (ClothesText.Text.Length > 0 && ClothesText.Text.Length < 4 && Convert.ToInt32(ClothesText.Text) > 169 && Convert.ToInt32(ClothesText.Text) < 196) 
            {
                if (Convert.ToInt32(ClothesText.Text) < 180) 
                {
                    ClothesLabel.Text = "46";
                }
                if (Convert.ToInt32(ClothesText.Text) > 179 && Convert.ToInt32(ClothesText.Text)<184)
                {
                    ClothesLabel.Text = "48";
                }
                if (Convert.ToInt32(ClothesText.Text) > 179 && Convert.ToInt32(ClothesText.Text) < 184)
                {
                    ClothesLabel.Text = "50";
                }
                if (Convert.ToInt32(ClothesText.Text) > 183 && Convert.ToInt32(ClothesText.Text) < 188)
                {
                    ClothesLabel.Text = "52";
                }
                if (Convert.ToInt32(ClothesText.Text) > 188)
                {
                    ClothesLabel.Text = "54";
                }
            }
            else ClothesLabel.Text = "Error";
            if (ShoesText.Text.Length > 0 && ShoesText.Text.Length < 4 && Convert.ToInt32(ShoesText.Text) > 22 && Convert.ToInt32(ShoesText.Text) < 31) 
            {
                if (Convert.ToInt32(ShoesText.Text) == 23)
                {
                    ShoesLabel.Text = "39";
                }
                if (Convert.ToInt32(ShoesText.Text) == 24)
                {
                    ShoesLabel.Text = "40";
                }
                if (Convert.ToInt32(ShoesText.Text) == 25)
                {
                    ShoesLabel.Text = "41";
                }
                if (Convert.ToInt32(ShoesText.Text) == 26)
                {
                    ShoesLabel.Text = "42";
                }
                if (Convert.ToInt32(ShoesText.Text) == 27)
                {
                    ShoesLabel.Text = "43";
                }
                if (Convert.ToInt32(ShoesText.Text) == 28)
                {
                    ShoesLabel.Text = "44";
                }
                if (Convert.ToInt32(ShoesText.Text) == 29)
                {
                    ShoesLabel.Text = "45";
                }
                if (Convert.ToInt32(ShoesText.Text) == 30)
                {
                    ShoesLabel.Text = "46";
                }
            }
            else ShoesLabel.Text = "Error";
        }

        private void Europian_Click(object sender, EventArgs e)
        {
            if (ClothesText.Text.Length > 0 && ClothesText.Text.Length < 4 && Convert.ToInt32(ClothesText.Text) > 169 && Convert.ToInt32(ClothesText.Text) < 196)
            {
                if (Convert.ToInt32(ClothesText.Text) < 180)
                {
                    ClothesLabel.Text = "44-48";
                }
                if (Convert.ToInt32(ClothesText.Text) > 179 && Convert.ToInt32(ClothesText.Text) < 184)
                {
                    ClothesLabel.Text = "48-52";
                }
                if (Convert.ToInt32(ClothesText.Text) > 179 && Convert.ToInt32(ClothesText.Text) < 184)
                {
                    ClothesLabel.Text = "52-56";
                }
                if (Convert.ToInt32(ClothesText.Text) > 183 && Convert.ToInt32(ClothesText.Text) < 188)
                {
                    ClothesLabel.Text = "56-58";
                }
                if (Convert.ToInt32(ClothesText.Text) > 188)
                {
                    ClothesLabel.Text = "60";
                }
            }
            else ClothesLabel.Text = "Error";
            if (ShoesText.Text.Length > 0 && ShoesText.Text.Length < 4 && Convert.ToInt32(ShoesText.Text) > 22 && Convert.ToInt32(ShoesText.Text) < 31)
            {
                if (Convert.ToInt32(ShoesText.Text) == 23)
                {
                    ShoesLabel.Text = "40.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 24)
                {
                    ShoesLabel.Text = "41.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 25)
                {
                    ShoesLabel.Text = "42.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 26)
                {
                    ShoesLabel.Text = "43.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 27)
                {
                    ShoesLabel.Text = "44.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 28)
                {
                    ShoesLabel.Text = "45.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 29)
                {
                    ShoesLabel.Text = "46.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 30)
                {
                    ShoesLabel.Text = "47.5";
                }
            }
            else ShoesLabel.Text = "Error";
            flag = false;
            ErrorLabel.Text = "";
            counter = 0;
        }

        private void Britain_Click(object sender, EventArgs e)
        {
            if (ClothesText.Text.Length > 0 && ClothesText.Text.Length < 4 && Convert.ToInt32(ClothesText.Text) > 169 && Convert.ToInt32(ClothesText.Text) < 196)
            {
                if (Convert.ToInt32(ClothesText.Text) < 180)
                {
                    ClothesLabel.Text = "36-38";
                }
                if (Convert.ToInt32(ClothesText.Text) > 179 && Convert.ToInt32(ClothesText.Text) < 184)
                {
                    ClothesLabel.Text = "39-41";
                }
                if (Convert.ToInt32(ClothesText.Text) > 179 && Convert.ToInt32(ClothesText.Text) < 184)
                {
                    ClothesLabel.Text = "42-44";
                }
                if (Convert.ToInt32(ClothesText.Text) > 183 && Convert.ToInt32(ClothesText.Text) < 188)
                {
                    ClothesLabel.Text = "45-47";
                }
                if (Convert.ToInt32(ClothesText.Text) > 188)
                {
                    ClothesLabel.Text = "47-48";
                }
            }
            else ClothesLabel.Text = "Error";
            if (ShoesText.Text.Length > 0 && ShoesText.Text.Length < 4 && Convert.ToInt32(ShoesText.Text) > 22 && Convert.ToInt32(ShoesText.Text) < 31)
            {
                if (Convert.ToInt32(ShoesText.Text) == 23)
                {
                    ShoesLabel.Text = "7";
                }
                if (Convert.ToInt32(ShoesText.Text) == 24)
                {
                    ShoesLabel.Text = "7.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 25)
                {
                    ShoesLabel.Text = "8.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 26)
                {
                    ShoesLabel.Text = "9";
                }
                if (Convert.ToInt32(ShoesText.Text) == 27)
                {
                    ShoesLabel.Text = "9.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 28)
                {
                    ShoesLabel.Text = "10.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 29)
                {
                    ShoesLabel.Text = "11.5";
                }
                if (Convert.ToInt32(ShoesText.Text) == 30)
                {
                    ShoesLabel.Text = "12";
                }
            }
            else ShoesLabel.Text = "Error";
            flag = false;
            ErrorLabel.Text = "";
            counter = 0;
        }
        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) 
            {
                e.Handled = true;
            }
            if(number == (char)Keys.Back) 
            {
                e.Handled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
