using ClassLibrary1;
using System;
using System.Diagnostics;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var test = new Test();
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            int a = 5;
            Debug.WriteLine("a is: {0}", a);

         




            var sw = new Stopwatch();
            sw.Start();
            int x = int.Parse(Console.ReadLine());
            sw.Stop();
            Debug.WriteLine(sw.ElapsedTicks);





            Console.ReadKey();


        }

        /// <summary>
        /// This function add...
        /// </summary>
        public void add(int x, int y)
        {
            throw new System.NotImplementedException();

        }
    }
}
