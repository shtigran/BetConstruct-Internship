using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceExample;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallelepiped shape1 = new Parallelepiped();
            shape1.display();

            Parallelepiped shape2 = new Parallelepiped("Parallelepiped2", 4, 5, 6);
            shape2.display();

            Parallelepiped shape3 = new Parallelepiped("NEWParallelepiped2", 8, 13, 9);
            shape3.display();


            Ellipsoid shape4 = new Ellipsoid();
            shape4.display();

            Ellipsoid shape5 = new Ellipsoid("Ellipsoid2", 2, 6, 8);
            shape5.display();

            Ellipsoid shape6 = new Ellipsoid("NEWEllipsoid2", 8, 13, 9);
            shape6.display();

            Console.ReadKey();


        }
    }
}
