using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number:");
            int n = int.Parse(Console.ReadLine().ToString());
            Console.WriteLine(CalcFactorial(n)); ;
            Console.ReadKey();
        }


        private static double CalcFactorial(int n)
        {

            double TotalSum = 0;
            double Fact = 1;

            for (int i = 1; i <= n; i++)
            {

                for (int j = i; j >=1 ; j--)
                {
                    Fact *= j;
                }

                TotalSum += Fact;
//                TotalSum += i / Fact; 
                Fact = 1;
            }

            return TotalSum;
        
        }
    }
}
