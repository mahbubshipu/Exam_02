using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var r=GetResult(10, 15,14,15,14,15,12,14);
            Console.WriteLine(r);
            Console.WriteLine("=============");
            var result = GetAB(14, 15);
            Console.WriteLine(result);

        }
        public static (int,int) GetAB(int x, int y)
        {
            int a = x + 10;
            int b = y * 20;
            return (a, b);
        }
        public static (int,double)GetResult(params int[]numbers)//Sir ar example
        {
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            return (sum / numbers.Length, sum*1.0 / numbers.Length);
        }

    }
}
