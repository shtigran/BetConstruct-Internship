using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InheritanceExample
{
    // Creating Base class Shape3d

    public abstract class Shape3d
    {

        public Shape3d()
        {

        }

        public Shape3d(string _name)
        {
            Name = _name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length > 15)
                {
                    this.name = value.Substring(0, 15);
                    Console.WriteLine("Your name is too long!!!");
                }
                else this.name = value;
            }
        }

        public abstract double GetVolume();
        public abstract void display();

        public const double pi = 3.14;
        private string name;
    }

    // Creating first derived class Parallelepiped

    public class Parallelepiped : Shape3d
    {

        public Parallelepiped()
        {
            Name = "Parallelepiped";

        }

        public Parallelepiped(string name, double Side_a, double Side_b, double Side_c)
            :base(name)
        {
            
            side_a = Side_a;
            side_b = Side_b;
            side_c = Side_c;
        }

        public override double GetVolume()
        {
            return side_a * side_b * side_c;
        }

        public override void display()
        {
            Console.WriteLine($"For shape: {Name} the volume is: {GetVolume()}\n");
        }

        private double side_a { get; set; }
        private double side_b { get; set; }
        private double side_c { get; set; }

    }

    // Creating second derived class Ellipsoid

    public class Ellipsoid : Shape3d
    {


        public Ellipsoid()
        {
            Name = "Ellipsoid";
        }


        public Ellipsoid(string _name, double _pole1, double _pole2, double _pole3)
            :base (_name)
        {
            pole1 = _pole1;
            pole2 = _pole2;
            pole3 = _pole3;
        }

        private double pole1;
        private double pole2;
        private double pole3;


        public override void display()
        {
            Console.WriteLine($"For shape: {Name} the volume is: {GetVolume()}\n");
        }

        public override double GetVolume()
        {
            return 4 * pi * pole1 * pole2 * pole3 / 3;
        }
    }




}