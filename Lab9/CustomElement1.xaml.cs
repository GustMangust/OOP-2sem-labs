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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab6_7
{
    /// <summary>
    /// Логика взаимодействия для CustomElement1.xaml
    /// </summary>
    public partial class CustomElement1 : UserControl
    {
        public CustomElement1()
        {
            InitializeComponent();
        }
        public void Control_MouseDown(object sender, RoutedEventArgs e) 
        {
            MessageBox.Show("sender: " + sender.ToString() + "\n");
            MessageBox.Show("source: " + e.Source.ToString() + "\n\n");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sender: " + sender.ToString() + "\n");
            MessageBox.Show("source: " + e.Source.ToString() + "\n\n");
        }
        private void MessageBox_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("RoutedUICommand");
        }
    }
}
