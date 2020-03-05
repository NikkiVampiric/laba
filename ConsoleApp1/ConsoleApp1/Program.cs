using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first, last;
            Console.WriteLine("Enter name: ");
            first = Console.ReadLine();
            Console.WriteLine("Enter lastname: ");
            last = Console.ReadLine();
            Console.WriteLine("Hello, {0} {1}", first, last);
            Console.ReadLine();
        }
    }
}
