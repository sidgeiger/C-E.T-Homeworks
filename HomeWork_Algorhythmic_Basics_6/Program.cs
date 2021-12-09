using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HomeWork_Algorhythmic_Basics_6
{
    class Program
    {
        //todo eeegzzsyerrerer
        //0-3000 írd ki a szökő éveket
        //Szökőév minden olyan év, amelynek az évszáma néggyel osztható, kivéve a 100-zal osztható dátumok. A kivétel alóli kivételt a 400-zal osztható dátumok adják,
        //vagyis például 2000 is szökőév volt, ám 2100 már nem lesz az.
        static void Main(string[] args)
        {
            Console.WriteLine("A szökőévek 0-3000 között:");
            for (int i = 1; i < 3001; i++)
            {

                if (i % 4 == 0 && i < 100)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(400);
                    continue;
                }
                else if (i % 4 == 0)
                {
                    if (i % 100 == 0 && i % 400 == 0 )
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(400);
                        continue;
                    }
                    if (i % 100 == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                    Thread.Sleep(400);
                }
                
            }
            Console.ReadKey();
        }
    }
}
