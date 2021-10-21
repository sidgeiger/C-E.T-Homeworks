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
            for (short i = 0; i < 543; i++)
            {
                if (i <= 1)
                    continue;
                else if (i == 2 || i== 3)
                {
                    Console.WriteLine(i);
                }
                else if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                {
                    continue;
                }
                else
                {
                    //A range-ben minden számot ellenőrizni, hogy osztható-e a "2...2 négyzetnének" tartomány bármely számával.
                    for (short j = 2; j * j <= i; j++)
                    {
                        //ha van osztó, a maradék nem lehet 0
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

