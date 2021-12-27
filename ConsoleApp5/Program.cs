using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("A Program To Clac Area And Circumference : ( Circle , Square , Rectangle , Triangle ) ");
            string i = "Yes";
            do
            {
                Console.WriteLine("Enter What Shape You Need Of (Circle , Square , Rectangle , Triangle) : ");
                string input_Action = Console.ReadLine();
                if (input_Action == "Circle")
                {
                    Console.WriteLine("Enter The Radius Of The Circle : ");
                    Circle C = new Circle();
                    C.area();
                    C.circumference();
                    C.Print();
                }
                else if (input_Action == "Square")
                {
                    Console.WriteLine("Enter The Length Of The Side Of The Square : ");
                    Square S = new Square();
                    S.area();
                    S.circumference();
                    S.Print();
                }
                else if (input_Action == "Rectangle")
                {
                    Console.WriteLine("Enter The Length Of The Rectangle : ");
                    Console.WriteLine("Enter The Width Of The Rectangle : ");
                    Rectangle R = new Rectangle();
                    R.area();
                    R.circumference();
                    R.Print();
                }
                else if (input_Action == "Triangle")
                {
                    Console.WriteLine("Enter The Length Base : ");
                    Console.WriteLine("Enter The Height : ");
                    Triangle T = new Triangle("");
                    T.area();
                    T.Print();
                    Console.WriteLine("Enter The S1 : ");
                    Console.WriteLine("Enter The S2 : ");
                    Console.WriteLine("Enter The S3 : ");
                    Triangle T2 = new Triangle();
                    T2.circumference();
                    T2.Printcircumferenceonly();
                }
                else
                {
                    Console.WriteLine("Plz Enter A Valid Word");
                }

                Console.WriteLine("Wanna Calc Again ? ");
                string itteration = i = Console.ReadLine();

            } while (i == "Yes");
                
                Console.WriteLine("Thanks");

        }
    }

}
