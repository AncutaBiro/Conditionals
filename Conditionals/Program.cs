using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = Console.ReadLine();

            int price = 0;
            switch (color)
            {
                case "red":
                    price = 10;
                    break;
                case "purple":
                    goto case "blue";
                case "blue":
                    price += 1;
                    goto case "green";
                case "green":
                    price += 2;
                    goto case "white";
                case "white":
                    price += 6;
                    break;
                default:
                    price = 5;
                    break;
            }
            Console.WriteLine(price);
            Console.Read();
        }
    }
}
