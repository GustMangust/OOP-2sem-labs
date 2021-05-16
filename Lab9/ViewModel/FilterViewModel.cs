using DevExpress.Mvvm;
using Lab6_7.Serialize;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Specialized;

namespace Lab6_7.ViewModel
{
    class FilterViewModel:ViewModelBase
    {
        ObservableCollection<Book> Books;
        Serialization ser;
        private TextBlock selected_item;
        public TextBlock Selected_item 
        {
            get 
            {
                return selected_item;
            }
            set 
            {
                selected_item = value;
                RaisePropertyChanged("Selected_item");
            }
        }
        public ICommand apply => new DelegateCommand(Apply);
        public void Back()
        {
            MainWindow win = new MainWindow();
            win.Show();
            foreach (System.Windows.Window window in System.Windows.Application.Current.Windows)
            {
                if (window.DataContext == this)
                {
                    window.Close();
                }
            }
        }
        public void Apply() 
        {
            if(Selected_item != null) 
            {
                switch (Selected_item.Text) 
                {
                    case "Автор":
                        var linqList = from b in Books
                                       orderby b.Author_name ascending
                                       select b;
                        ObservableCollection<Book> Book = new ObservableCollection<Book>(linqList);
                        if (ser.DeseriaizeFlag())
                        {
                            ser.SerializePrev(ser.Deseriaize());
                            ser.Serialize(Book);
                        }
                        else
                        {
                            ser.SerializeFlag(true);
                            ser.Serialize(Book);
                        }
                        Back();
                        break;
                    case "Author":
                        var linqList4 = from b in Books
                                       orderby b.Author_name ascending
                                       select b;
                        ObservableCollection<Book> Book4 = new ObservableCollection<Book>(linqList4);
                        if (ser.DeseriaizeFlag())
                        {
                            ser.SerializePrev(ser.Deseriaize());
                            ser.Serialize(Book4);
                        }
                        else
                        {
                            ser.SerializeFlag(true);
                            ser.Serialize(Book4);
                        }
                        Back();
                        break;
                    case "Название":
                        var linqList1 = from b in Books
                                       orderby b.Full_title ascending
                                       select b;
                        ObservableCollection<Book> Book1 = new ObservableCollection<Book>(linqList1);
                        if (ser.DeseriaizeFlag())
                        {
                            ser.SerializePrev(ser.Deseriaize());
                            ser.Serialize(Book1);
                        }
                        else
                        {
                            ser.SerializeFlag(true);
                            ser.Serialize(Book1);
                        }
                        Back();
                        break;
                    case "Title":
                        var linqList5 = from b in Books
                                       orderby b.Full_title ascending
                                       select b;
                        ObservableCollection<Book> Book5 = new ObservableCollection<Book>(linqList5);
                        if (ser.DeseriaizeFlag())
                        {
                            ser.SerializePrev(ser.Deseriaize());
                            ser.Serialize(Book5);
                        }
                        else
                        {
                            ser.SerializeFlag(true);
                            ser.Serialize(Book5);
                        }
                        Back();
                        break;
                    case "Категория":
                        var linqList2 = from b in Books
                                       orderby b.Category ascending
                                       select b;
                        ObservableCollection<Book> Book2 = new ObservableCollection<Book>(linqList2);
                        if (ser.DeseriaizeFlag())
                        {
                            ser.SerializePrev(ser.Deseriaize());
                            ser.Serialize(Book2);
                        }
                        else
                        {
                            ser.SerializeFlag(true);
                            ser.Serialize(Book2);
                        }
                        Back();
                        break;
                    case "Category":
                        var linqList6 = from b in Books
                                       orderby b.Category ascending
                                       select b;
                        ObservableCollection<Book> Book6 = new ObservableCollection<Book>(linqList6);
                        if (ser.DeseriaizeFlag())
                        {
                            ser.SerializePrev(ser.Deseriaize());
                            ser.Serialize(Book6);
                        }
                        else
                        {
                            ser.SerializeFlag(true);
                            ser.Serialize(Book6);
                        }
                        Back();
                        break;
                    case "Цена":
                        var linqList3 = from b in Books
                                       orderby b.Price ascending
                                       select b;
                        ObservableCollection<Book> Book3 = new ObservableCollection<Book>(linqList3);
                        if (ser.DeseriaizeFlag())
                        {
                            ser.SerializePrev(ser.Deseriaize());
                            ser.Serialize(Book3);
                        }
                        else
                        {
                            ser.SerializeFlag(true);
                            ser.Serialize(Book3);
                        }
                        Back();
                        break;
                    case "Price":
                        var linqList7 = from b in Books
                                       orderby b.Price ascending
                                       select b;
                        ObservableCollection<Book> Book7 = new ObservableCollection<Book>(linqList7);
                        if (ser.DeseriaizeFlag())
                        {
                            ser.SerializePrev(ser.Deseriaize());
                            ser.Serialize(Book7);
                        }
                        else
                        {
                            ser.SerializeFlag(true);
                            ser.Serialize(Book7);
                        }
                        Back();
                        break;
                }
            }
        }
        public FilterViewModel() 
        {
            ser = new Serialization();
            if (ser.DeseriaizeFlag())
                Books = ser.Deseriaize();
            else
            {
                Books = ser.DeseriaizePrev();
            }
        }
    }
}
