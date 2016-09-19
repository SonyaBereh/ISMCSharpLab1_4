using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B:");
            int B = int.Parse(Console.ReadLine());
            int Result = 0;
            if (A < B)
            {
                while (A <= B)
                {
                    Result = Result + A * A;
                    A++;

                }
            }

            Console.WriteLine(Result);
        }
    }
}
