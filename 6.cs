using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(Calc(x));
            Console.ReadKey();

        }

        private static int Calc(int x)
        {

            string XS = x.ToString();
            int multi = 1;

            for (int i = 0; i <XS.Length; i++)
            {
                if (int.Parse(XS[i].ToString()) > 5)
                {
                    multi *= int.Parse(XS[i].ToString());
                }
            }


            return multi;

        }

    }
}
