using System;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            for (var i = 0; i < size; i++)
            {
                var mid = Math.Abs((size / 2) - i);

                for (var j = 0; j < size; j++)
                {
                    if (j < mid || j > (size - mid - 1))
                        Console.Write(' ');
                    else
                        Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
