using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A: ");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            double Result = 1;
            if (N <= 0)
                Console.WriteLine("Ошибка: N < 0");
            else
            {
                for (int i = 0; i < N; i++)
                {
                    Result = Result * A;
                }
                Console.WriteLine(Result);
            }
        }
    }
}
