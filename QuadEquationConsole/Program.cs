using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadEquationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            int c = int.Parse(Console.ReadLine());
            double D;
            D = b * b - 4 * a * c;
            Console.Write("D = ");
            Console.WriteLine(D);
            if (D > 0)
            {
                double x1, x2;
                x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
                Console.Write("x1 = ");
                Console.WriteLine(x1);
                Console.Write("x2 = ");
                Console.WriteLine(x2);
            }
            else if (D == 0)
            {
                double x;
                x = (-b) / (2 * a);
                Console.Write("x = ");
                Console.WriteLine(x);
            }
            else
                Console.WriteLine("Решений не существует.");
        }
    }
}
