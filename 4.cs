using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number:");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(IsSquare(x));

            Console.ReadKey();
        }


        private static bool IsSquare(int x)
        {
            int z = (int)Math.Sqrt(x);
            if (z * z == x)
            {
                return true;
            }
            else return false;
        }
    }
}
