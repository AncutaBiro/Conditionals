/*La un spectacol artistic biletul de intrare pentru copiii sub vârsta de 14 ani are 50% reducere.
Să se scrie o aplicație consolă ce primește ca date de intrare prețul întreg al biletului și vârsta unei persoane și 
afișează prețul pe care persoana respectivă trebuie să-l plătească pentru un bilet la spectacol.

Exemplu:
Pentru datele de intrare:
60
9
La consolă se va afișa:
30*/

using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            string inputData = Console.ReadLine();
                        int listPrice = Convert.ToInt32(inputData);

                        inputData = Console.ReadLine();
                        int age =  Convert.ToInt32(inputData);*/

            /*            int halfOffPrice = (listPrice * 50) / 100;
                        Console.WriteLine(halfOffPrice);
                        Console.Read();*/

            double listPrice = 4;
            double age = 10;

            double finalPrice = (age < 14) ? 0 : 1;

            Console.WriteLine(finalPrice);
            Console.Read();
        }
    }
}
