using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HomeWork_Algorhythmic_Basics_5
{
    class Program
    {
        //0-10000 írd ki az összes prím számot
        static void Main(string[] args)
        {
            short k = 0;
            for (short i = 0; i < 31; i++)
            {
                if (i <= 1)
                    continue;
                else if (i == 2 || i== 3)
                {
                    Console.WriteLine(i);
                }
                else if (i % 2 == 0)
                {
                    continue;
                }
                else
                { 
                    for (short j = 2; j * j <= i; j++)
                    {
                        // If a divisor of n exists
                        if (i % j != 0)
                        {
                            if (k == i)
                            {
                                continue;
                            }
                            Console.WriteLine(i);
                            k = i;
                        }
                            
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

