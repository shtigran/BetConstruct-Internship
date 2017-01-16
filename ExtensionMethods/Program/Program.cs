using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1233424,5";
            string str1 = "Only text";

            Console.WriteLine(str.HasLetter());
            Console.WriteLine(str1.HasLetter());
            Console.WriteLine(str.HasNumber());
            Console.WriteLine(str1.HasNumber());
            Console.WriteLine(str.HasPunctuation());
            Console.WriteLine(str1.HasPunctuation());
            Console.WriteLine(str1.ConCat(str));

            Console.ReadKey();

        }
    }
}
