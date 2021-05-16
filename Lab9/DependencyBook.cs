using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Lab6_7
{
    class DependencyBook : DependencyObject
    {
        public static readonly DependencyProperty TitleProperty;
        public static readonly DependencyProperty PriceProperty;

        static DependencyBook()
        {
            TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(DependencyBook));
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);
            PriceProperty = DependencyProperty.Register("Price", typeof(int), typeof(DependencyBook), metadata,new ValidateValueCallback(ValidateValue));
        }
        private static bool ValidateValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue >= 0)
                return true;
            return false;
        }
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 1000) 
                return 1000;
            return currentValue;
        }
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public int Price
        {
            get { return (int)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }
    }
}
