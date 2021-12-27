using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Square : Shape
    {
        private double L;
        public Square()
        {
            this.L = double.Parse(Console.ReadLine());
        }
        public override double area()
        {
            return (L * L);
        }
        public override double circumference()
        {
            return (L * 4);
        }
        public override void Print()
        {
            Console.WriteLine("The Area Of Square is : {0}", area());
            Console.WriteLine("The circumference Of Square is : {0}", circumference());
        }
    }
}
