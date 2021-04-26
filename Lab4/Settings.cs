using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Settings
    {
        Form1 mainForm = new Form1();
        public Color bgColor;
        public Font font;
        public int height;
        public int width;

        private Settings()
        {
            bgColor = mainForm.BackColor;
            font = mainForm.Font;
            height = mainForm.Height;
            width = mainForm.Width;
        }
        private static Settings _instance;
        public static Settings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Settings();
            }
            return _instance;
        }
        public string Info()
        {
            return $"{bgColor}, {font},{height},{width}";
        }
    }
}
