using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab6_7
{
    /// <summary>
    /// Логика взаимодействия для CustomElement.xaml
    /// </summary>
    public partial class CustomElement : UserControl
    {
        public CustomElement()
        {
            InitializeComponent();
            DoubleAnimation Animation = new DoubleAnimation();
            Animation.From = spText.ActualWidth;
            Animation.To = 150;
            Animation.Duration = TimeSpan.FromSeconds(3);
            spText.BeginAnimation(Button.WidthProperty, Animation);
        }
    }
}
