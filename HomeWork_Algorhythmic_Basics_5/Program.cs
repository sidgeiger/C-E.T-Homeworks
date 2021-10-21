
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
            byte counter = 0;
            for (int i = 0; i < 10001; i++)
            {
                if (i <= 1)
                    continue;
                else if (i == 2 || i == 3)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    for (int j = 2; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            counter++;
                        }
                        
                    }
                    if (counter < 2)
                    {
                        Console.WriteLine(i);
                    }
                    counter = 0;
               }
                
               
            }
            Console.ReadKey();

        }
    }
}