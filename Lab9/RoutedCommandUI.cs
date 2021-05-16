using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lab6_7
{
    class RoutedCommandUI
    {
        static RoutedCommandUI()
        {
            MessageBox = new RoutedCommand("MessageBox", typeof(CustomElement1));
        }
        public static RoutedCommand MessageBox { get; set; }

    }
}
