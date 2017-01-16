using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ForStrings
    {

        public static bool HasLetter (this string str)
        {
            for (int i = 0; i <str.Length; i++)
            {
               if(char.IsLetter(str[i]))
                    return true;
            }
            return false;
        }

        public static bool HasNumber (this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsNumber(str[i]))
                    return true;
            }
            return false;
        }

        public static bool HasPunctuation (this string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsPunctuation(str[i]))
                    return true;
            }
            return false;
        }

        public static string ConCat (this string str, string str1)
        {
            string result = str + str1;
            return result;
        }
             
    }
}
