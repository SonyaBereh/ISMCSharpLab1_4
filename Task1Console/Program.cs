using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону а: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b: ");
            int b = int.Parse(Console.ReadLine());
            int S = a * b; 
            int P = 2 * (a + b);
            Console.WriteLine("Площадь прямоугольника равна" + S + ".");
            Console.WriteLine("Периметр прямоугольника равен " + P + "."); 
        }
    }
}
