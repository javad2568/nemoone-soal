using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number n:");
            int n = int.Parse(Console.ReadLine().ToString());

            Console.WriteLine("enter number x:");
            int x = int.Parse(Console.ReadLine().ToString());

            Console.WriteLine(CalcFactorial(n, x)); ;
            Console.ReadKey();
        }


        private static double CalcFactorial(int n, int x)
        {
         
            double TotalSum = 0;
            double Fact = 1; double p = 0;

            for (int i = 1; i <= n; i++)
            {

                for (int j = i; j >= 1; j-=2)
                {
                    Fact *= j;
                }

                p = Math.Pow(x, i);

                if (i % 2 == 0)
                {
                    p *= -1;
                }

                TotalSum += p / Fact;

                
                Fact = 1;
            }

            return TotalSum;

        }


      

       
    }
}
