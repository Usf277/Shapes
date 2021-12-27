using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Rectangle : Shape
    {
        private double L;
        private double W;
        public Rectangle()
        {
            this.L = double.Parse(Console.ReadLine());
            this.W = double.Parse(Console.ReadLine());
        }
        public override double area()
        {
            return (L * W);
        }
        public override double circumference()
        {
            return (2*(L + W));
        }
        public override void Print()
        {
            Console.WriteLine("The Area Of Rectangle is : {0}", area());
            Console.WriteLine("The circumference Of Rectangle is : {0}", circumference());
        }
    }
}
