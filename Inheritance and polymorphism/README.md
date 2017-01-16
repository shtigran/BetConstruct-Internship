
# Inheritance of abstract classe and polimorphizm
# C#6  .NET4.6
----

### Purpose
The destination of this project intorduce simple example of inheritance and polimorfizm. 

----
### Based class implementation
```c#
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
```
### Description of Shape3d class
Base class name is Shape3d and describes the properties of 3d objects.
This is based class from wich derive two other classes. This class implements two constructors, one property, two abstract methods (which must be overrided in derived classes) and has one field and one constant. The first constructor is the default constuctor, which must be explicit implemented if we have another constructor. The second constructor take string and give it to Name property, that after condition return the value to the name private field. The two abstract methods must be overrided in derived classes. The first method calculate the volume of object and the second show that results.

### The Ellipsoid derived class implementation
```c#
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
```
### Description of Ellipsoid class
In this class we add two constructors, three fields (specific for this class) and have overrided base class two abstract methods.

### The Parallelepiped derived class implementation
```c#
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
```
### Description of Parallelepiped class
In this class we also add two constructors, three fields (specific for this class) and have overrided base class two abstract methods.

### Test 
```c#
            Parallelepiped shape1 = new Parallelepiped();
            shape1.display();

            Parallelepiped shape2 = new Parallelepiped("Parallelepiped2", 4, 5, 6);
            shape2.display();

            Parallelepiped shape3 = new Parallelepiped("NEWParallelepiped2", 8, 13, 9);
            shape3.display();
            Console.WriteLine();

            Ellipsoid shape4 = new Ellipsoid();
            shape4.display();

            Ellipsoid shape5 = new Ellipsoid("Ellipsoid2", 2, 6, 8);
            shape5.display();

            Ellipsoid shape6 = new Ellipsoid("NEWEllipsoid2", 8, 13, 9);
            shape6.display();
```
To illustrate Inheritance and Polimorphizm we create 6 objects of two derive classes and invoke their overrided methods.
### Result

_____Example of Inheritance_____

For shape: Parallelepiped the volume is: 0

For shape: Parallelepiped2 the volume is: 120

Your name is too long!!!
For shape: NEWParallelepip the volume is: 936

For shape: Ellipsoid the volume is: 0

For shape: Ellipsoid2 the volume is: 401,92

For shape: NEWEllipsoid2 the volume is: 3918,72

