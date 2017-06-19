using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int calculationResult = Calculate(4, 5);
            Console.WriteLine("Result of the calculation: {0}", calculationResult);

            Console.ReadLine();
        }

        static int Calculate(int a, int b)
        {
            int result = a * b;

            return result;
        }
    }
}
