using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first day of week (shanbe = 0 , 1shanbe = 1 ,...)");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("s0\ts1\ts2\ts3\ts4\ts5\tj");
            
            string tabCount = "";
            int DayCounter = n;

            for (int i = 0; i < n; i++)
            {
                tabCount += "\t";
                
            }

            for (int i = 1; i <= 12; i++)
            {
                if (i == 12)
                { }
                if (i <= 6)
                {
                    for (int j = 1; j <= 31; j++)
                    {
                        if (DayCounter > 6)
                        {
                            Console.WriteLine();
                            Console.Write( j);
                            DayCounter = 1;
                            tabCount = "\t";
                           
                        }
                        else
                        {
                            Console.Write(tabCount + j);
                            DayCounter++;
                            tabCount = "\t";
                            
                        }

                       
                    }

                    tabCount = "";
                    for (int z = 0; z < DayCounter; z++)
                    {
                        
                        tabCount += "\t";

                    }

                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= 30; j++)
                    {
                        if (DayCounter > 6)
                        {
                            Console.WriteLine();

                            Console.Write( j);

                            DayCounter = 1;
                            tabCount = "\t";

                        }
                        else
                        {
                            Console.Write(tabCount + j);

                            DayCounter++;
                            tabCount = "\t";

                        }
                    }

                    tabCount = "";
                    for (int z = 0; z < DayCounter; z++)
                    {
                       
                        tabCount += "\t";

                    }
                    Console.WriteLine();
                    Console.WriteLine();

                }
                
            }
            ////
            ////Console.WriteLine("\t\t1");
            Console.ReadKey();
            
        }

        //private static string DayOfWeekName(int i)
        //{ 
            


        //}
    }
}
