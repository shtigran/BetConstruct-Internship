using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethod;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {


            int number1 = 525;
            Console.WriteLine(number1.IsPolindrom());
            number1 = 0;
            Console.WriteLine(number1.IsPolindrom());
            number1 = 4;
            Console.WriteLine(number1.IsPolindrom());
            number1 = -2332;
            Console.WriteLine(number1.IsPolindrom());
            number1 = -1;
            Console.WriteLine(number1.IsPolindrom());
            number1 = 332;
            Console.WriteLine(number1.IsPolindrom());
            number1 = 55555;
            Console.WriteLine(number1.IsPolindrom());
            number1 = 888;
            Console.WriteLine(number1.IsPolindrom());


            Console.ReadKey();

        }
    }
}
