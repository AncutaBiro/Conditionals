/*
Scrie o aplicație ce primește de la tastatură numele unei luni din an și afișează anotimpul din care face parte luna respectivă. 
Dacă utilizatorul introduce o lună ce nu există se va afișa textul luna invalida.
Exemplu:
Pentru datele de intrare:
aprilie
La consolă se va afișa:
primavara*/

using System;

namespace Test3Pb1Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
          
            switch (month)
            {
                case "decembrie":
                    Console.WriteLine("iarna");
                    break;
                case "ianuarie":
                    Console.WriteLine("iarna");
                    break;
                case "februarie":
                    Console.WriteLine("iarna");
                    break;
                case "martie":
                    Console.WriteLine("primavara");
                    break;
                case "aprilie":
                    Console.WriteLine("primavara");
                    break;
                case "mai":
                    Console.WriteLine("primavara");
                    break;
                case "iunie":
                    Console.WriteLine("vara");
                    break;
                case "iulie":
                    Console.WriteLine("vara");
                    break;
                case "august":
                    Console.WriteLine("vara");
                    break;
                case "septembrie":
                    Console.WriteLine("toamna");
                    break;
                case "octombrie":
                    Console.WriteLine("toamna");
                    break;
                case "noiembrie":
                    Console.WriteLine("toamna");
                    break;
                default:
                    Console.WriteLine("luna invalida");
                    break;
            }
        }
    }
}
