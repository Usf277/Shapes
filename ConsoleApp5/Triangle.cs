using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Triangle : Shape 
    {
        private double height;
        private double base_length;
        public double S1;
        public double S2;
        public double S3;

        public Triangle()
        {
            this.S1 =  double.Parse(Console.ReadLine());
            this.S2 =  double.Parse(Console.ReadLine());
            this.S3 =  double.Parse(Console.ReadLine());
        }
        public Triangle(string a)
        {
            this.height = double.Parse(Console.ReadLine());
            this.base_length = double.Parse(Console.ReadLine());
        }
        public override double area()
        {
            return 0.5*(base_length*height);
        }
        public override double circumference()
        {
            return (S1+S2+S3);
        }
        public override void Print()
        {
            Console.WriteLine("The Area Of Triangle is : {0}", area());
        }
        public void Printcircumferenceonly()
        {
            Console.WriteLine("The circumference Of Triangle is : {0}", circumference());
        }
    }
}
