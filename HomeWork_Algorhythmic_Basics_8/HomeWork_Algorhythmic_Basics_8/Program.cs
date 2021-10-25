using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HomeWork_Algorhythmic_Basics_8
{
    // TODO Generálj 5 és 20 között egy random egész számot.Amennyi lett, annyi sorban írj ki egy nullákból álló fél piramist.
    //Pl: 6 a random szám
    //0
    //00
    //000
    //0000
    //00000
    //000000
    // TODO Ha megy akkor írj ki egy egész piramist is így.A csúcsa 2 nulla legyen.
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int num = rnd.Next(5, 20);
            Console.WriteLine("A véletlen generált szám, ami a piramis magassága:" + num);
            for (int i = 1; i <= num; i++)
            {
                
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("0");
                    Thread.Sleep(100);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
