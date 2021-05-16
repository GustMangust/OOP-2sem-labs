using DevExpress.Mvvm;
using Lab6_7.Serialize;
using Lab6_7.Validate;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;

using System.Windows.Input;
using System.Xml.Serialization;

namespace Lab6_7.ViewModel
{
    class AddProductViewModel:ViewModelBase
    {
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
        public void AddBook()
        {
            if (Validation.RatingValidate(Rating) && Validation.AmountAndPriceValidate(Amount) && Validation.AmountAndPriceValidate(Price) && Validation.TitleCategoryAuthorValidate(Full_title) && Validation.TitleCategoryAuthorValidate(Category) && Validation.TitleCategoryAuthorValidate(Author_name) && Validation.PictureValidate(Picture) && Validation.DescriptionValidate(Description))
            {
                Serialization ser = new Serialization();
                if (ser.DeseriaizeFlag()) 
                {
                    ser.SerializePrev(ser.Deseriaize());
                    ser.Serialize(Full_title, Author_name, Description, Category, Picture, Rating, Amount, Price);
                }
                else 
                {
                    ser.SerializeFlag(true);
                    ser.Serialize(ser.DeseriaizePrev());
                    ser.Serialize(Full_title, Author_name, Description, Category, Picture, Rating, Amount, Price);
                }
                Back();
            }
            else Visibility = Visibility.Visible;
        }
        public ICommand addBook => new DelegateCommand(AddBook);
        public ICommand loadImg => new DelegateCommand(LoadImg);
        public void LoadImg() 
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
                Picture = dialog.FileName;
            }
        }
        public AddProductViewModel() 
        {
            
            Visibility = Visibility.Hidden;
        }
    }
}
