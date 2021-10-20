using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Homework_Algorythmic_Basics_3
{
    // Kérj be bármilyen szöveget a felhasználótól. Fordítva írd ki konzolra.

    class Program
    {

        static void Main(string[] args)
        {
            //var i = new userStringIterator();
            

            string  userString = string.Empty;
            Console.WriteLine("Kérlek, irj be bármit, de legalább két karatertből álljon! :");
            bool isStringOK = false;
            do
            {
                try
                {
                    userString = (Convert.ToString(Console.ReadLine()));
                    if (string.IsNullOrWhiteSpace(userString) || userString.Length < 2)
                    {
                        Console.WriteLine("\nKérlek, megfelelő karaktereket adj meg! :");
                    }
                    else
                    {
                        isStringOK = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nHiba! Írj be valamit! :");
                }
                
                
            } while (!isStringOK);
            //converting string array to char array
            var ca = userString.ToCharArray();
            int numberOfChars = userString.Length;
            Console.WriteLine("Ennyi karaktert ütöttél be: " + numberOfChars + "(" + userString + ").");
            Console.WriteLine("Fúúú de jó lesz, most megfordítom, amit beírtál!!!");
            //string char- jainak megfordítása            
            Thread.Sleep(2000);
            for (int i = 0; i < ca.Length; i++)
            {
                char characterA = ca[i];
                if (ca.Length % 2 == 0)
                {
                    if (i == (ca.Length / 2))
                    {
                        break;
                    }
                    ca[i] = ca[(ca.Length - 1) - i];
                    ca[(ca.Length - 1) - i] = characterA;

                }
                if (ca.Length % 2 != 0)
                {
                    if (i == (ca.Length - 1) - i)
                    {
                        ca[i] = ca[(ca.Length - 1) - i];
                        ca[(ca.Length - 1) - i] = characterA;
                        break;
                    }
                    ca[i] = ca[(ca.Length - 1) - i];
                    ca[(ca.Length - 1) - i] = characterA;
                }
                
            }
            Console.WriteLine(ca);
            Console.ReadKey();
        }
    }
}
