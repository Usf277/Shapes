using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Circle : Shape
    {
        public double radius;
         
        public Circle()
        {
            this.radius = double.Parse(Console.ReadLine());
        }
        public override double area()
        {
            return (3.14 * radius * radius);
        }
        public override double circumference()
        {
            return (2 * 3.14 * radius);
        }
        public override void Print()
        {
            Console.WriteLine("The Area Of Circle is : {0}", area());
            Console.WriteLine("The circumference Of Circle is : {0}", circumference());
        }
        
    }
}
