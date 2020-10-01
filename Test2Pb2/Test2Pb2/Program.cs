using System;

namespace Test2Pb2
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputData = Console.ReadLine();
            double rent = (double)Convert.ToDouble(inputData);

            inputData = Console.ReadLine();
            double days = (double)Convert.ToDouble(inputData);

            double penalty1 = (rent * 2) / 100;

            Console.WriteLine(penalty1);
            Console.Read();
        }
    }
}
