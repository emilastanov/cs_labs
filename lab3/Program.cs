using System;
using System.Collections;
using System.Collections.Generic;
using SparseMatrix;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rctngl = new Rectangle(10, 15);
            Square sqr = new Square(10);
            Circle crcl = new Circle(5*Math.Sqrt(5)/Math.Sqrt(Math.PI));

            ArrayList arrList = new ArrayList();
            arrList.Add(rctngl);
            arrList.Add(sqr);
            arrList.Add(crcl);

            Console.WriteLine("ArrayList without sort:\n");
            foreach (var figure in arrList) Console.WriteLine(figure);

            arrList.Sort();

            Console.WriteLine("\n\nSorted ArrayList:\n");
            foreach (var figure in arrList) Console.WriteLine(figure);

            List<Figure> figureList = new List<Figure>();
            figureList.Add(rctngl);
            figureList.Add(sqr);
            figureList.Add(crcl);

            Console.WriteLine("\n\nList<Figure> without sort:\n");
            foreach (var figure in figureList) Console.WriteLine(figure);

            figureList.Sort();

            Console.WriteLine("\n\nSorted List<Figure>:\n");
            foreach (var figure in figureList) Console.WriteLine(figure);

            Matrix3D<Figure> cube = new Matrix3D<Figure>(3, 3, 3, null);
            cube[0, 0, 0] = rctngl;
            cube[1, 1, 1] = sqr;
            cube[2, 2, 2] = crcl;
            Console.WriteLine(cube.ToString());
           
            Console.ReadKey();
        }
    }
}
