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
        internal static void Swapper(char[] ca, int i, char characterA)
        {
            ca[i] = ca[(ca.Length - 1) - i];
            ca[(ca.Length - 1) - i] = characterA;
        }

        static void Main(string[] args)
        {
            string userString = string.Empty;
            Console.WriteLine("Kérlek, irj be bármit, de legalább két karatertből álljon! :");
            bool isStringOK = false;
            do
            {
                userString = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userString) || userString.Length < 2)
                {
                    Console.WriteLine("\nKérlek, megfelelő karaktereket adj meg! :");
                }
                else
                {
                    isStringOK = true;
                }

            } while (!isStringOK);
            //converting string array to char array
            var ca = userString.ToCharArray();
            int numberOfChars = userString.Length;
            Console.WriteLine("Ennyi karaktert ütöttél be: " + numberOfChars + "(" + userString + ").");
            Console.WriteLine("Fúúú de jó lesz, most megfordítom, amit beírtál!!!");
            //string char- jainak megfordítása            
            //for (int i = 0; i < ca.Length; i++)
            //{
            //    char characterA = ca[i];
            //    if (ca.Length % 2 == 0)
            //    {
            //        if (i == (ca.Length / 2))
            //        {
            //            break;
            //        }
            //        Swapper(ca, i, characterA);

            //    }
            //    if (ca.Length % 2 != 0)
            //    {
            //        if (i == (ca.Length - 1) - i)
            //        {
            //            Swapper(ca, i, characterA);
            //            break;
            //        }
            //        Swapper(ca, i, characterA);

            //    }

            //}

            for (int i = 0; i < ca.Length / 2; i++)
            {
                char characterA = ca[i];
                Swapper(ca, i, characterA);
            }
            Console.WriteLine(ca);
            Console.ReadKey();
        }
    }
}
