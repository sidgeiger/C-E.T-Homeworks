using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Algorhythmic_Basics_7
{
    class Program
    {
        // bemenő paraméterek átnézése, IsEven 1 sorban megírható

        // Írd ki az első 20 fibonachi számot.Írd mellé, hogy prím-e, Írd mellé, hogy páros, vagy pártlan. Írd mellé, hogy szökőév-e.
        // függvényeket felvenni és minden elemen futtatni
        // prím vagy nem prím
        // páros vagy páratlan
        // szökőév vagy nem
        static bool PrimeOrNotPrime(short _item, bool _isPrime)
        {
                byte counter = 0;
                
                if (_item == 1)
                {
                    _isPrime = false;
                }
                else if (_item == 2 || _item == 3)
                {
                    _isPrime = true;
                }
                else
                {
                    for (int i = 2; i <= _item; i++)
                    {
                        if (_item % i == 0)
                        {
                            counter++;
                            _isPrime = false;
                        }

                    }
                    if (counter < 2)
                    {
                        _isPrime = true;
                    }
                    counter = 0;
                }
            return _isPrime;
            }
        static bool EvenOrOdd(short _item, bool _isPrime)
        {
            if (_item % 2 == 0)
            {
                _isPrime = true;
            }
            else
            {
                _isPrime = false;
            }
            return _isPrime;
        }
        static bool EscapingYear(short _item, bool _isescapingYear)
        {
            //szökőév kiszámítása
            if (_item % 4 == 0 && _item < 100)
            {
                _isescapingYear = true;
            }
            else if(_item % 4 == 0)
            {
                _isescapingYear = true;
                if (_item % 100 == 0 && _item % 400 == 0)
                {
                    _isescapingYear = true;
                }
                else if(_item % 100 == 0)
                {
                    _isescapingYear = false;
                }
            }
            else
            {
                _isescapingYear = false;
            }
            
            return _isescapingYear;
            
        }
        static void Main(string[] args)
        {
            bool isPrime = false;
            bool isEven = false;
            bool isescapingYear = false;
            var fibonacciNumbers = new List<short> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                short previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                short previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                short fibNum = (short)(previous + previous2);
                fibonacciNumbers.Add(fibNum);
                
            }
            foreach (var item in fibonacciNumbers)
            {
                isPrime = PrimeOrNotPrime(item, isPrime);
                isEven = EvenOrOdd(item, isEven);
                isescapingYear = EscapingYear(item, isescapingYear);
                Console.Write(item);
                if (isPrime)
                {
                    Console.Write("   Prímszám,");
                }
                else
                {
                    Console.Write("   Nem prímszám,");
                }
                if (isEven)
                {
                    Console.Write("   Páros,");
                }
                else
                {
                    Console.Write("   Páratlan,");
                }
                if (isescapingYear)
                {
                    Console.WriteLine("   Szökőév,");
                }
                else
                {
                    Console.WriteLine("   Nem szökőév,");
                }
            }
            Console.ReadKey();

        }
    }
}
