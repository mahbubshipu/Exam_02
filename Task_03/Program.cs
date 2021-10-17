using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic data = new { name = "Shipu", age = 20 };
            Console.WriteLine($"Name:{data.name} Age:{data.age}");
        }
    }
}
