using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your nubmber:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(IsTrain(x));

            Console.ReadKey();
        }


        private static int IsTrain(int x)
        {


            for (int i = 1; i < x; i++)
            {
                if((i*(i+1)/2) == x)
                {
                return 1;
                }
            }

            return 0;

        }
    }
}
