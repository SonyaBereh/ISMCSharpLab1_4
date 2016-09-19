using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            double N = double.Parse(Console.ReadLine());
            double Result = 0;
            double B = 1;
            double C = 0;
            if (N <= 0)
                Console.WriteLine("Ошибка: N <= 0.");
            else
            {
                while (C != N)
                {
                    B = B * (C + 1);
                    Result = Result + B;
                    C++;

                }
            }
               
                Console.WriteLine(Result);
            
            }
        }
    }

