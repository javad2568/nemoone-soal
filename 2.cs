using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your number:");
            int A = int.Parse(Console.ReadLine());

            for (int i = 1; i < A; i++)
            {
                for (int j = 1; j <= A/2; j++)
                {
                    if (i + j == A)
                    {
                        if (CheckForAval(i) && CheckForAval(j))
                        {
                            Console.WriteLine(i+"+"+j+"= "+(i+j));
                            
                        }
                    }
                }
            }

            Console.ReadKey();
        }


        private static bool CheckForAval(int x)
        {

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
            
        }


    }
}
