using Lab6_7.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace Lab6_7.View
{
    /// <summary>
    /// Логика взаимодействия для FilterPage.xaml
    /// </summary>
    public partial class FilterPage : Window
    {
        public FilterPage()
        {
            InitializeComponent();
            StreamResourceInfo sri = Application.GetResourceStream(
             new Uri("rocketanimated2.ani", UriKind.RelativeOrAbsolute));
            Cursor customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;
            DataContext = new FilterViewModel();
        }
    }
}
