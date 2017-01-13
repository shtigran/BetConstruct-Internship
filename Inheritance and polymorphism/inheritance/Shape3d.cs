using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InheritanceExample
{
    
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
}