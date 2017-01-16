using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days;

namespace DaysIndexer
{
    class Program
    {
        static void Main(string[] args)
        {

            EnumDays day = new EnumDays();
            Console.WriteLine($"The Friday is the {day["Friday"]}-th day");
            Console.WriteLine($"The Saturday is the {day["Saturday"]}-th day");
            Console.WriteLine($"The Monday is the {day["Monday"]}-th day");



            Console.ReadKey();
        }
    }
}
