using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static List<Discipline> list = new List<Discipline>();
        XmlSerializer formatter = new XmlSerializer(typeof(List<Discipline>));
        public Form1()
        {
            InitializeComponent();
            KursList.SelectedIndex = 0;
            SpecList.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ToXml_Click(object sender, EventArgs e)
        {
            
            if (AmountOfLectures.Text.Length > 0 && AmountOfLabs.Text.Length > 0 && NameOfDisc.Text.Length > 0 && Department.Text.Length > 0 && Cabinet.Text.Length == 5 && FullnameOfLecturer.Text.Length > 0 && FileWrite.Text.Length > 0 && Department.Text.Length > 0) 
            {
                MessageBox.Show("Объект сериализован");
                Discipline disc = new Discipline();
                if (RadioSem1.Checked)
                    disc.semestr = 1;
                else disc.semestr = 2;
                disc.name = NameOfDisc.Text;
                disc.kurs = Convert.ToInt32(KursList.SelectedItem);
                disc.spec = (string)SpecList.SelectedItem;
                disc.amountOfLectures = Convert.ToInt32(AmountOfLectures.Text);
                disc.amountOfLabs = Convert.ToInt32(AmountOfLabs.Text);
                if (RadioExam.Checked)
                    disc.formOfTest = "Экзамен";
                else disc.formOfTest = "Зачёт";
                disc.lecturer.department = Department.Text;
                disc.lecturer.cabinet = Cabinet.Text;
                disc.lecturer.fullname = FullnameOfLecturer.Text;
                list.Add(disc);
                using (FileStream fs = new FileStream($"{FileWrite.Text}.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, list);
                    Console.WriteLine("Объект десериализован");
                }
            }
        }
        private void FromXml_Click(object sender,EventArgs e) 
        {
            if (File.Exists($"{FileWrite.Text}.xml")) 
            {
                using (FileStream fs = new FileStream($"{FileWrite.Text}.xml", FileMode.OpenOrCreate))
                {
                    toXMLtext.Text = "";
                    List<Discipline> newList = (List<Discipline>)formatter.Deserialize(fs);
                    foreach (Discipline newDisc in newList)
                    {
                        toXMLtext.Text += $"Название: {newDisc.name}\r\nСеместр: {newDisc.semestr}\r\nКурс: {newDisc.kurs}\r\nСпециальность: {newDisc.spec}\r\nКоличество лекций:{newDisc.amountOfLectures}\r\nКоличество лаб:{newDisc.amountOfLabs}\r\nЗачёт или экзамен: {newDisc.formOfTest}\r\nЛектор\r\nКафедра преподавателя: {newDisc.lecturer.department}\r\nФИО:{newDisc.lecturer.fullname}\r\nАудитория: {newDisc.lecturer.cabinet}\r\n";
                        toXMLtext.Text += "---------------------------\r\n";
                    }
                }
            }
        }

        private void AmountOfKeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            TextBox text = sender as TextBox;

            if (text.Text.Length > 1) 
            {
                e.Handled = true;
            }
            if(number == (char)Keys.Back) 
            {
                e.Handled = false ;
            }
        }
        private void StringOfKeyPress(object sender, KeyPressEventArgs e) 
        {
            TextBox text = sender as TextBox;
            char number = e.KeyChar;
            if (!Char.IsLetter(number))
            {
                e.Handled = true;
            }
            if(number == (char)Keys.Back ||(number == (char)Keys.Space && text.Text.Length > 0))
            {
                e.Handled = false;
            }
        }
        private void CabinetOfKeyPress(object sender, KeyPressEventArgs e) 
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            if (Char.IsDigit(number) && (Cabinet.Text.Length < 3 || (Cabinet.Text.Length > 3 && Cabinet.Text.Length < 5)))
            {
                e.Handled = false;
            }
            else e.Handled = true;
            if (number == (char)Keys.Back)
            {
                e.Handled = false;
            }
            if(number == '-' && Cabinet.Text.Length==3)
            {
                e.Handled = false;
            }
        }
    }
    public class Lecturer 
    {
        public string department;
        public string fullname;
        public string cabinet;
        public Lecturer() 
        {
        }
    }
    public class Discipline
    {
        public int semestr;
        public string name;
        public int kurs;
        public string spec;
        public int amountOfLectures;
        public int amountOfLabs;
        public string formOfTest;
        public Lecturer lecturer = new Lecturer();
        public Discipline() 
        {
        }

    }
}
