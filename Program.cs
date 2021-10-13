using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HomeWork_Algorhythmic_Basics_1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            // Végy fel egy 10 elemű, egész számokat tartalmazó tömböt.Töltsd fel random számokkal.
            // Írd ki az összes elemét konzolra.
            // Keresd meg a tömben lévő legnagyobb értékű számot.
            // Írd ki az értékét, és az indexét is.
            // For, while és do -while ciklussal is végezd el.
            int[] myArray = new int[10];
            Console.WriteLine("Random elements in myArray are:");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(-2000000, 2000000);
                Console.WriteLine(myArray[i]);
            }
            Console.ReadKey();

            Console.WriteLine("Search for the highest element in array:");
            Console.ReadKey();

            int highestElement_1 = myArray[0];
            int index_1 = 0;
            for (int i = 0; i < myArray.Count(); i++)
            {
                if (highestElement_1 < myArray[i])
                {
                    highestElement_1 = myArray[i];
                    index_1 = i;
                }
            }
            Console.WriteLine("The highest element is: " + highestElement_1 + ", found at position (index): " + index_1 + ".");
            Console.ReadKey();

            Console.Write("Repeating task using 'while' cycle......");
            Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100);
            Console.WriteLine("\nNew random elements in myArray are:");
            int j = 0;
            while (j < myArray.Length)
            {
                myArray[j] = rnd.Next(-2000000, 2000000);
                Console.WriteLine(myArray[j]);
                j++;
            }
            Console.ReadKey();
            Console.WriteLine("Search for the highest element in array:");
            Console.ReadKey();

            int highestElement_2 = myArray[0];
            int index_2 = 0;
            j = 1;
            while (j < myArray.Length)
            {
                if (highestElement_2 < myArray[j])
                {
                     highestElement_2 = myArray[j];
                     index_2 = j;
                }
                j++;
            }
            Console.WriteLine("The highest element is: " + highestElement_2 + ", found at position (index): " + index_2 + ".");
            Console.ReadKey();
            Console.Write("Repeating task using 'do-while' cycle......");
            Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100); Console.Write("/"); Thread.Sleep(100); Console.Write("\\"); Thread.Sleep(100);
            Console.WriteLine("\nNew random elements in myArray are:");
            int k = 0;
            do
            {
                myArray[k] = rnd.Next(-2000000, 2000000);
                Console.WriteLine(myArray[k]);
                k++;
            } while (k < myArray.Length);
            Console.ReadKey();
            Console.WriteLine("Search for the highest element in array:");
            Console.ReadKey();

            int highestElement_3 = myArray[0];
            int index_3 = 0;
            k = 1;
            do
            {
                if (highestElement_3 < myArray[k])
                {
                    highestElement_3 = myArray[k];
                    index_3 = k;
                    
                }
                k++;
            } while (k < myArray.Length);
            Console.WriteLine("The highest element is: " + highestElement_3 + ", found at position (index): " + index_3 + ".");
            Console.ReadKey();

        }
    }
}
