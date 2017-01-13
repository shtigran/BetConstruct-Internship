using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceExample;

namespace inheritance
{
    public class Parallelepiped : Shape3d
    {

        public Parallelepiped()
        {
            Name = "Parallelepiped";

        }

        public Parallelepiped(string name, double Side_a, double Side_b, double Side_c)
            : base(name)
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
}
