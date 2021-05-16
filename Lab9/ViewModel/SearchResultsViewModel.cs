using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Lab6_7.ViewModel
{
    class SearchResultsViewModel:ViewModelBase
    {
        public ObservableCollection<Book> Books { get; set; }
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
        public SearchResultsViewModel(List<Book> list) 
        {
            Books = new ObservableCollection<Book>(list);
        }
    }
}
