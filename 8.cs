using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number:");
            int n = int.Parse(Console.ReadLine());
            PrintX(n);
            Console.ReadKey();
        }

        private static void PrintX(int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
    }
}
