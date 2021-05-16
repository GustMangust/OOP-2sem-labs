using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows;

namespace GoodFood.Model
{
    public class Picture
    {
        public Picture()
        {

        }
        public Picture(Bitmap source)
        {
            this.Source = source;
        }
        Bitmap source;
        public Bitmap Source
        {
            get { return source; }
            set { source = value; }
        }
        public string PictureString
        {
            get
            {
                MemoryStream ms = new MemoryStream();
                source.Save(ms, ImageFormat.Bmp);
                byte[] byteImage = ms.ToArray();
                return Convert.ToBase64String(byteImage); 
            }
            set
            {
                Bitmap bmpReturn;
                MessageBox.Show(value);
                byte[] byteBuffer = Convert.FromBase64String(value);
                MemoryStream memoryStream = new MemoryStream(byteBuffer);
                memoryStream.Position = 0;
                bmpReturn = (Bitmap)Image.FromStream(memoryStream);
                memoryStream.Close();
                source = bmpReturn;
            }
        }
    }
}
