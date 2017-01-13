using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceExample;

namespace inheritance
{
    public class Ellipsoid : Shape3d
    {
        public Ellipsoid()
        {
            Name = "Ellipsoid";
        }


        public Ellipsoid(string _name, double _pole1, double _pole2, double _pole3)
            : base(_name)
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
