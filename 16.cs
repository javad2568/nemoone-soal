using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x:");
            int x = int.Parse(Console.ReadLine());


            Console.WriteLine("enter y:");
            int y = int.Parse(Console.ReadLine());


            Console.WriteLine("enter z:");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine(check(x, y, z));
            Console.ReadKey();

        }

        private static int check(int x, int y, int z)
        {

            if (x == y && y == z)
            {
                return 3;
            }
            else if (Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(z, 2) || Math.Pow(x, 2) + Math.Pow(z, 2) == Math.Pow(x, 2) || Math.Pow(x, 2) + Math.Pow(z, 2) == Math.Pow(y, 2))
            {
                return 1;
            }
            else if ((x == y && z != x) || ((x == z) && y != x) || ((z == y) && x != y))
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }
    }
}
