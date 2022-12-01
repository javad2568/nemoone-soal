using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number k:");
            int k = int.Parse(Console.ReadLine().ToString());

            Console.WriteLine("enter number x:");
            int x = int.Parse(Console.ReadLine().ToString());

            Console.WriteLine(Log(k, x)); ;
            Console.ReadKey();
        }


        private static double Log(int k, int x)
        {
            Math.Log(x, k);
            return Math.Log(x, k);
        }
    }
}
