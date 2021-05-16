using DevExpress.Mvvm;
using Lab6_7.Serialize;
using Lab6_7.View;
using Lab6_7.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Linq;
using static System.Net.Mime.MediaTypeNames.Application;

namespace Lab6_7
{
    public class AppViewModel : ViewModelBase
    {
        Serialization ser = new Serialization();
        private ObservableCollection<Book> books;
        public ObservableCollection<Book> Books 
        {
            get 
            {
                return books;
            }
            set 
            { 
                books = value;
                RaisePropertyChanged("Books");
            } 
        }
        private Book selectedBook;
        public Book SelectedBook
        {
            get 
            {
                return selectedBook;
            }
            set
            {
                selectedBook = value;
                RaisePropertyChanged("SelectedBook");
            }
        }

        public void AddProduct() 
        {
            AddProduct win = new AddProduct();
            win.Show();
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext == this)
                {
                    window.Close();
                }
            }
        }
        public ICommand openAddProduct => new DelegateCommand(AddProduct);
        private void EditBoook()
        {
            EditBookPage win = new EditBookPage();
            win.Show();
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext == this)
                {
                    window.Close();
                }
            }
        }
        public bool flag=true;
        private void Undo()
        {
            Books = ser.DeseriaizePrev();
            flag = false;
            ser.SerializeFlag(flag);
        }
        private void Redo() 
        {
            Books = ser.Deseriaize();
            flag = true;
            ser.SerializeFlag(flag);
        }
        public ICommand openSearch => new DelegateCommand(OpenSearch);
        public ICommand undo => new DelegateCommand(Undo);
        public ICommand redo => new DelegateCommand(Redo);
        private void OpenSearch()
        {
            SearchBookPage win = new SearchBookPage();
            win.Show();
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext == this)
                {
                    window.Close();
                }
            }
        }
        public ICommand openEditBook => new DelegateCommand(EditBoook);
        public ICommand openFilter => new DelegateCommand(Filter);
        public void Filter() 
        {
            FilterPage fp = new FilterPage();
            fp.Show();
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext == this)
                {
                    window.Close();
                }
            }
        }

        public AppViewModel()
        {

            /*
            ser.Serialize("Полковнику никто не пишет", "ПННП", "Габриэль Гарсия Маркес", "Классная", "Новелла", @"C:\Users\GustMangust\Desktop\Cover_sg_via2000.jpg", 5, 500, 200);
            ser.Serialize("Норвежский лес", "НЛ", "Харуки Мураками", "Про лес", "Роман", @"C:\Users\GustMangust\Desktop\hto-ja-zelenskij-mem-1.png", 4, 200, 350);
            ser.Serialize("Старик и море", "СИМ", "Эрнест Хэмингуэй", "Море", "Повесть", @"C:\Users\GustMangust\Desktop\billy.jpg", 2, 120, 800);*/
            /*Books = new ObservableCollection<Book>();
            Books.Clear();
            ser.Serialize(Books);*/
            if (ser.DeseriaizeFlag())
                Books = ser.Deseriaize();
            else 
            {
                Books = ser.DeseriaizePrev();
            }
        }
    }
}
