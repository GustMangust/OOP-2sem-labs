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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void LecturerSearchButton_Click(object sender, EventArgs e)
        {
            if(MainForm.newList.Count > 0) 
            {
                LecturerSearchForm form = new LecturerSearchForm();
                form.Show();
            }
        }

        private void SemestrSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void KursSearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
