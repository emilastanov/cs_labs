using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static double input() {
            double a;
            string str = Console.ReadLine();
            try
            {
                a = Double.Parse(str);
                return a;
            }
            catch (Exception e)
            {
                Console.WriteLine("Вы ввели не число, попробуйте снова!");
                return input();
            }
        }
        static void calculate(double A, double B, double C)
        {
            double D = Math.Sqrt(B * B - 4 * A * C);
            if (double.IsNaN(D))
            {
                Console.WriteLine("Вещественного дискриминанта не существует!");
            }
            else 
            {
                Console.WriteLine("Корни: ");
                Console.Write((-B + D) / (2 * A));
                Console.Write(" ");
                Console.Write((-B - D) / (2 * A));
            }
        }
        static void Main(string[] args)
        {
            double A, B, C, D;
            Console.WriteLine("Введите старший коэффициент (А): ");
            A = input();
            Console.WriteLine("Введите коэффициент при 'x' (B): ");
            B = input();
            Console.WriteLine("Введите свободный коэффициент (С): ");
            C = input();
            calculate(A, B, C);
            Console.ReadKey();
        }
    }
}