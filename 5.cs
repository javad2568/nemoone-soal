using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number:");
            int salary = int.Parse(Console.ReadLine());

            double x = CalcTax(salary);

            Console.WriteLine(x);
            Console.ReadKey();
        }


        private static double CalcTax(int Salary)
        {

            if (Salary <= 483000)
            {
                return 0;
            }
            else if (Salary > 483000 && Salary <= 600000)
            {
                return (Salary * 10) / 100;
            }
            else if (Salary > 600000 && Salary <= 1000000)
            {
                return (Salary * 15) / 100;
            }
            else if (Salary > 1000000 && Salary <= 2000000)
            {
                return (Salary * 20) / 100;
            }
            else if (Salary > 2000000 )
            {
                return (Salary * 30) / 100;
            }

            return 0;
            
        }
    }
}
