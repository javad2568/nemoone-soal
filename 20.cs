using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
             int n = 15;
            Console.WriteLine(F(15));
            Console.ReadKey();

        }
        private static int F(int n)
        {
            if (n == 1) ;
            {
                return 2;
            }
            return 2 * F(n - 1) + 1;
        }
    }
}
