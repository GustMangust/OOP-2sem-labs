using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab6_7
{
    public class Book//: INotifyPropertyChanged
    {
        /*private string name;
        private string author_name;
        private int price;
        public string Name
        {
            get
            {
                return name;
            }
            set 
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Author_name
        {
            get
            {
                return author_name;
            }
            set 
            {
                author_name = value;
                OnPropertyChanged("Author_name");
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set 
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }*/
    public Book() { }
    public Book(string ft, string a, string d, string c, string pic, int r, int am, int p) 
        {
            Full_title = ft;
            Author_name = a;
            Description = d;
            Category = c;
            Picture = pic;
            Rating = r;
            Amount = am;
            Price = p;
        }
        public string Full_title { get; set; }
        public string Author_name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Picture { get; set; }
        public int Rating { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
    }
}
