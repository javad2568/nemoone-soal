using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your char :");
            string x = Console.ReadLine().ToString();

           // var dd = Encoding.ASCII.GetBytes(x);

          //  Console.WriteLine( dd[0]);

            CheckChar(x[0]);
            Console.ReadKey();
        }


        private static void CheckChar(char x)
        {
            
            if (char.IsDigit(x))
            {
                Console.WriteLine(x+ " is number");
            }
            else if (char.IsLower(x))
            {

                Console.WriteLine(x + " is lower char");
            }
            else if(char.IsUpper(x))
            {
                Console.WriteLine(x + " is upper char");
                
            }
            else
            {
                Console.WriteLine("unknown");

            }
            

        }
    }
}
