using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HomeWork_Algorhythmic_Basics_2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //  Végy fel egy 10 elemű, egész számokat tartalmazó tömböt.Töltsd fel random számokkal.
            //  Írd ki az összes elemét konzolra.
            //  Rendezd növekvő sorrendbe.
            //  Írd ki a tömböt.
            //  Rendezd csökennő sorendbe.
            //  Írd ki a tömböt.
            int[] newArray = new int[10];
            int valueCache;

            Console.WriteLine("Newly random elements in newArray are:");
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = rnd.Next(-2000000, 2000000);
                Console.WriteLine(newArray[i]);
            }
            //emelkedő sorrend nested for-ral
            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = 0; j < newArray.Length; j++)
                {
                    //túlindexelés figyelése
                    if (j == newArray.Length-1)
                    {
                        break;
                    }
                    if (newArray[j] > newArray[j + 1])
                    {
                        valueCache = newArray[j];
                        newArray[j] = newArray[j + 1];
                        newArray[j + 1] = valueCache;
                    }
                 
                }               
            }
            Console.WriteLine("Elements in ASCENDING ORDER are as follows:");
            foreach (int elements in newArray)
            {
                Thread.Sleep(300);
                Console.WriteLine(elements);
            }
            Console.ReadKey();
            //csökkenő sorrend nested for-ral 
            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = 0; j < newArray.Length; j++)
                {
                    //túlindexelés figyelése
                    if (j == newArray.Length - 1)
                    {
                        break;
                    }
                    if (newArray[j] < newArray[j + 1])
                    {
                        valueCache = newArray[j];
                        newArray[j] = newArray[j + 1];
                        newArray[j + 1] = valueCache;
                    }

                }
            }

            Console.WriteLine("Elements in DESCENDING ORDER are as follows:");
            foreach (int elements in newArray)
            {
                Thread.Sleep(300);
                Console.WriteLine(elements);
            }
            Console.ReadKey();



            
          
 
        }
    }
}
