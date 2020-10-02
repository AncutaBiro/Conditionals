/*
Convertește un număr dat, între 1 și 100, în cifre romane.
I - 1
V - 5
X - 10
L - 50
C - 100
Câteva exemple de comversie:
4 - IV
8 - VIII
9 - IX
15 - XV
30 - XXX
39 - XXXIX
41 - XLI
45 - XLV
99 - XCIX
Aplicația va citi de la consolă numărul și va afișa numărul scris cu cifre romane.

Exemplu:
Pentru datele de intrare:
4
La consolă se va afișa:
IV
 */

using System;

namespace Test2Pb3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            int n = Convert.ToInt32(inputData);

            Console.WriteLine (intToRoman(n));
            Console.Read();
        }
        static string intToRoman(int n)
            {
            if (n < 0) return "INVALID";

            if (n == 0 ) return "";
            if (n == 4) return "IV" + intToRoman(n - 4);
            if (n == 9) return "IX" + intToRoman(n - 9);
            if (n >= 40 && n < 50) return "XL" + intToRoman(n - 40);
            if (n >= 90 && n < 100) return "XC" + intToRoman(n - 90);

            if (n <= 3) return "I" + intToRoman(n - 1);
            if (n < 10) return "V" + intToRoman(n - 5);
            if (n < 40) return "X" + intToRoman(n - 10);
            if (n < 100) return "L" + intToRoman(n - 50);
            if (n == 100) return "C";
            
            return "INVALID";
            }
        }
    }

