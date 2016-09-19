using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            double N = double.Parse(Console.ReadLine());
            double i = 1;
            double Result = 0;
            if (N <= 0)
                Console.WriteLine("Введите другое число, чтобы N>0.");
            else 
            {
                while (i != N)
                {
                    
                    Result = Result + 1 / i;
                    i++;
                }
            
            }
            Console.WriteLine(Result);
             

        }
    }
}
