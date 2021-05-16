using DevExpress.Mvvm;
using Lab6_7.Serialize;
using Lab6_7.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lab6_7.ViewModel
{
    class SearchBookViewModel:ViewModelBase
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
        private string property;
        public string Property
        {
            get
            {
                return property;
            }
            set
            {
                property = value;
                RaisePropertyChanged("Property");
            }
        }
        public ICommand apply => new DelegateCommand(Apply);
        public ICommand back => new DelegateCommand(Back);
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
        public void OpenResults(List<Book> list) 
        {
            SearchResultsPage win = new SearchResultsPage(list);
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
            if (Selected_item != null && Property!=null)
            {
                string pattern = @$"{Property}(\w*)";
                List<Book> list = new List<Book>();
                switch (Selected_item.Text)
                {
                    case "Автор":
                        foreach (Book b in Books)
                        {
                            if(Regex.IsMatch(b.Author_name, pattern, RegexOptions.IgnoreCase)) 
                            {
                                list.Add(b);
                            }
                        }
                        OpenResults(list);
                        break;
                    case "Author":
                        foreach (Book b in Books)
                        {
                            if(Regex.IsMatch(b.Author_name, pattern, RegexOptions.IgnoreCase)) 
                            {
                                list.Add(b);
                            }
                        }
                        OpenResults(list);
                        break;
                    case "Название":
                        foreach (Book b in Books)
                        {
                            if (Regex.IsMatch(b.Full_title, pattern, RegexOptions.IgnoreCase))
                            {
                                list.Add(b);
                            }
                        }
                        OpenResults(list);
                        break;
                    case "Title":
                        foreach (Book b in Books)
                        {
                            if (Regex.IsMatch(b.Full_title, pattern, RegexOptions.IgnoreCase))
                            {
                                list.Add(b);
                            }
                        }
                        OpenResults(list);
                        break;
                    case "Категория":
                        foreach (Book b in Books)
                        {
                            if (Regex.IsMatch(b.Category, pattern, RegexOptions.IgnoreCase))
                            {
                                list.Add(b);
                            }
                        }
                        OpenResults(list);
                        break;
                    case "Category":
                        foreach (Book b in Books)
                        {
                            if (Regex.IsMatch(b.Category, pattern, RegexOptions.IgnoreCase))
                            {
                                list.Add(b);
                            }
                        }
                        OpenResults(list);
                        break;
                }
            }
        }
        public SearchBookViewModel() 
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
