using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework_Algorythmic_Basics_4
{
    class Program
    {
        //Végy fel egy 10 elemű, egész számokat tartalmazó tömböt.Töltsd fel random számokkal.
        //Írd ki mindegyik elemről, hogy páros, vagy páratlan.
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("10 elemű tömb feltöltése random számokkal:");
            int[] randomArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                randomArray[i] = rnd.Next(-2000000, 2000000);
                Console.WriteLine(randomArray[i]);
            }
            Console.WriteLine("Listázzuk a tömbben lévő PÁROS számokat:");
            Console.ReadKey();
            foreach (var item in randomArray)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                    Thread.Sleep(400);
                }
            }
            Console.WriteLine("Listázzuk a tömbben lévő PÁRATLAN számokat:");
            foreach (var item in randomArray)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine(item);
                    Thread.Sleep(400);
                }
            }
            Console.ReadKey();
        }
    }
}
