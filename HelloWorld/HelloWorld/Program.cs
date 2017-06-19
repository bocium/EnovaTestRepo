using System;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.TraceInformation("Start");

            Console.WriteLine("Hello World!");

            Trace.TraceInformation("End");
            Console.ReadLine();
        }
    }
}
