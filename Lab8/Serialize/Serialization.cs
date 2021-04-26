using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Lab6_7.Serialize
{
    class Serialization
    {

        public ObservableCollection<Book> Deseriaize()
        {
            if (File.Exists("books.xml"))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Book>));
                using (FileStream fs = new FileStream("books.xml", FileMode.OpenOrCreate))
                {
                    return (ObservableCollection<Book>)formatter.Deserialize(fs);
                }
            }
            else return new ObservableCollection<Book>();
        }
        public ObservableCollection<Book> DeseriaizePrev()
        {
            if (File.Exists("books_prev.xml"))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Book>));
                using (FileStream fs = new FileStream("books_prev.xml", FileMode.OpenOrCreate))
                {
                    return (ObservableCollection<Book>)formatter.Deserialize(fs);
                }
            }
            else return new ObservableCollection<Book>();
        }
        public void Serialize(string ft,  string a, string d, string c, string pic, int r, int am, int p)
        {
            Book book = new Book(ft, a, d, c, pic, r, am, p);
            ObservableCollection<Book> list = Deseriaize();
            list.Add(book);
            XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Book>));
                using (FileStream fs = new FileStream("books.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, list);
                }
        }
        public void Serialize(ObservableCollection<Book> b)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Book>));
            using (FileStream fs = new FileStream("books.xml", FileMode.Create))
            {
                formatter.Serialize(fs, b);
            }
        }
        public void SerializePrev(ObservableCollection<Book> b)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<Book>));
            using (FileStream fs = new FileStream("books_prev.xml", FileMode.Create))
            {
                formatter.Serialize(fs, b);
            }
        }
        public void SerializeFlag(bool b)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(bool));
            using (FileStream fs = new FileStream("books_flag.xml", FileMode.Create))
            {
                formatter.Serialize(fs, b);
            }
        }
        public bool DeseriaizeFlag()
        {
            if (File.Exists("books_flag.xml"))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(bool));
                using (FileStream fs = new FileStream("books_flag.xml", FileMode.OpenOrCreate))
                {
                    return (bool)formatter.Deserialize(fs);
                }
            }
            else return new bool();
        }
    }
}
