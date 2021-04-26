using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LecturerSearchForm : Form
    {
        public LecturerSearchForm()
        {
            InitializeComponent();
        }

        private void LecturerFormSearchButton_Click(object sender, EventArgs e)
        {
            if(LecturerSearchTextBox.Text.Length > 0) 
            {
                Regex regex = new Regex($@"{LecturerSearchTextBox.Text}\w*");
                foreach(Discipline d in MainForm.newList) 
                {
                    if (regex.IsMatch(d.lecturer.fullname)) 
                    {
                        
                    }
                }
            }
        }
    }
}
