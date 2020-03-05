using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.ReadLine();
        }
    }
}
