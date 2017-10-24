using System;
using Figure;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rctngl = new Rectangle(10,15);
            Square sqr = new Square(Math.Sqrt(Math.E));
            Circle crcl = new Circle(5 / Math.Sqrt(Math.PI));

            rctngl.Print();
            sqr.Print();
            crcl.Print();

            Console.ReadKey();
        }
    }
}
