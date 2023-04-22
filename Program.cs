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
            youtuber.Create();

            Console.WriteLine();

            Console.WriteLine("--- Programmer --");
            programmer.Create();

            //Implementing Dynamic Polymorphism
            List<Creator> creators = new List<Creator>() { new Youtuber(), new Programmer()};

            foreach(var creator in creators)
            {
                Console.WriteLine(creator.GetType().Name);
                creator.Create();
                Console.WriteLine();
            }
        }
    }
}
