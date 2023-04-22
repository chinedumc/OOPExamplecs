using System;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator youtuber = new Youtuber();
            Creator programmer = new Programmer();

            Console.WriteLine("--- Youtuber ---");
            //Console.WriteLine();
            youtuber.Create();

            Console.WriteLine();

            Console.WriteLine("--- Programmer --");
            //Console.WriteLine();
            programmer.Create();
            //}
        }
    }
}
