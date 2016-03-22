using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                ifOdd(i);
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void ifOdd(int a)
        {
            if (a % 2 != 0)
            {
                Console.WriteLine("ODD");
            }
        }
    }
}
