using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab6_7.Validate
{
    class Validation
    {
        public static bool PictureValidate(string p)
        {
            if (p != null)
            {
                if (Regex.IsMatch(p, @"(\w*\.jpg\b)|(\w*\.bmp\b)|(\w*\.jpeg\b)|(\w*\.png\b)", RegexOptions.IgnoreCase)) return true;
                else return false;
            }
            else return false;
        }
        public static bool TitleCategoryAuthorValidate(string a)
        {
            if (Regex.IsMatch(a, @"^[a-zа-я0-9-_\s]{1,70}$", RegexOptions.IgnoreCase)) return true;
            else return false;
        }
        public static bool DescriptionValidate(string d)
        {
            if (Regex.IsMatch(d, @"^[а-яa-z0-9\x20\.\,\-]{1,70}$", RegexOptions.IgnoreCase)) return true;
            else return false;
        }
        public static bool AmountAndPriceValidate(int a) 
        {
            if (Regex.IsMatch(Convert.ToString(a), @"^([1-9][0-9]{0,8})$", RegexOptions.IgnoreCase)) return true;
            else return false;
        }
        public static bool RatingValidate(int r) 
        {
            if(Regex.IsMatch(Convert.ToString(r),@"^[1-5]$",RegexOptions.IgnoreCase)) return true;
            else return false;
        }
    }
}
