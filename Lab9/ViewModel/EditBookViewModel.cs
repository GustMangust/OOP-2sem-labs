using DevExpress.Mvvm;
using Lab6_7.Serialize;
using Lab6_7.Validate;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Lab6_7.ViewModel
{
    class EditBookViewModel:ViewModelBase
    {
        private Book selectedBook;
        public ObservableCollection<Book> Books { get; set; }
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
        private string full_title;
        public string Full_title
        {
            get
            {
                return full_title;
            }
            set
            {
                full_title = value;
                RaisePropertyChanged("Full_title");
            }
        }
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                RaisePropertyChanged("Title");
            }
        }
        private string author_name;
        public string Author_name
        {
            get
            {
                return author_name;
            }
            set
            {
                author_name = value;
                RaisePropertyChanged("Author_name");
            }
        }
        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                RaisePropertyChanged("Description");
            }
        }
        private string category;
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
                RaisePropertyChanged("Category");
            }
        }
        private string picture;
        public string Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
                RaisePropertyChanged("Picture");
            }
        }
        private int rating;
        public int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
                RaisePropertyChanged("Rating");
            }
        }
        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
                RaisePropertyChanged("Amount");
            }
        }
        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                RaisePropertyChanged("Price");
            }
        }
        private Visibility visibility;
        public Visibility Visibility
        {
            get
            {
                return visibility;
            }
            set
            {
                visibility = value;
                RaisePropertyChanged("Visibility");
            }
        }
        public ICommand editBook => new DelegateCommand(EditBook);
        public ICommand removeBook => new DelegateCommand(RemoveBook);
        public bool flag;
        public void EditBook()
        {
            flag = true;
            foreach (Book SelectedBook in Books)
            {
                if (!(Validation.RatingValidate(SelectedBook.Rating) && Validation.AmountAndPriceValidate(SelectedBook.Amount) && Validation.AmountAndPriceValidate(SelectedBook.Price) && Validation.TitleCategoryAuthorValidate(SelectedBook.Full_title) && Validation.TitleCategoryAuthorValidate(SelectedBook.Category) && Validation.TitleCategoryAuthorValidate(SelectedBook.Author_name) && Validation.PictureValidate(SelectedBook.Picture) && Validation.DescriptionValidate(SelectedBook.Description)))
                {
                    flag = false;
                    break;
                }
            }
            if (SelectedBook == null || !flag) 
            {
                flag = false;
                Visibility = Visibility.Visible;
            } 
            if (flag)
            {
                Serialization ser = new Serialization();
                if (ser.DeseriaizeFlag())
                {
                    ser.SerializePrev(ser.Deseriaize());
                    ser.Serialize(Books);
                }
                else
                {
                    ser.SerializeFlag(true);
                    ser.Serialize(Books);
                }
                Back();
            }
        }
        public void RemoveBook() 
        {
            if (selectedBook != null) 
            {
                if (ser.DeseriaizeFlag())
                {
                    ser.SerializePrev(ser.Deseriaize());
                    Books.Remove(SelectedBook);
                    ser.Serialize(Books);
                }
                else
                {
                    ser.SerializeFlag(true);
                    Books.Remove(SelectedBook);
                    ser.Serialize(Books);
                }
                Back();
            }
        }
        public ICommand loadImg => new DelegateCommand(LoadImg);
        public ICommand back => new DelegateCommand(Back);
        public void LoadImg()
        {
            if(SelectedBook!= null) 
            {
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    CheckFileExists = false,
                    CheckPathExists = true,
                    Multiselect = false,
                    Title = "Выберите файл"
                };

                if (dialog.ShowDialog() == true)
                {
                    SelectedBook.Picture = dialog.FileName;
                }
            }
        }
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
        Serialization ser;
        public EditBookViewModel()
        {
            Visibility = Visibility.Hidden;
            ser = new Serialization();
            if (ser.DeseriaizeFlag())
                Books = ser.Deseriaize();
            else
            {
                Books = ser.DeseriaizePrev();
            }
            /*{
                new Book("Полковнику никто не пишет", "ПННП", "Габриэль Гарсия Маркес", "Классная","Новелла",@"C:\Users\GustMangust\Desktop\Cover_sg_via2000.jpg",  5, 500,200),
                new Book("Норвежский лес", "НЛ", "Харуки Мураками", "Про лес","Роман",@"C:\Users\GustMangust\Desktop\hto-ja-zelenskij-mem-1.png", 4, 200,350),
                new Book("Старик и море","СИМ", "Эрнест Хэмингуэй",  "Море","Повесть",@"C:\Users\GustMangust\Desktop\billy.jpg",  2, 120,800)
                new Book {Name="Полковнику никто не пишет", Author_name="Габриэль Гарсия Маркес", Price=20 },
                new Book {Name="Норвежский лес", Author_name="Харуки Мураками", Price=35 },
                new Book {Name="Старик и море", Author_name="Эрнест Хэмингуэй", Price=42 }
            };*/

        }
    }
}
