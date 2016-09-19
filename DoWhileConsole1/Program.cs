using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rez = 0;
            int a = 0;
            do
            {
                int c = int.Parse(Console.ReadLine());
                rez += c;
                a = c;
            }
            while (a != 0);
          Console.Write("Сумма:");
          Console.WriteLine(rez);
        }
    }
}
