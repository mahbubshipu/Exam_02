using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(1, 2, 3, 4, 5, 67, 70);
            Console.WriteLine("========");
            int c = 5;
            Test3(ref c);
            Console.WriteLine(c);
            Console.WriteLine("========");
            int e = 0;
            int d = 0;
            Test4(out c, out d);
            Console.WriteLine("========");
            int a = 10;
            Test2(in a);
            Console.WriteLine(a);
        }
        public static void Test(params int[]a)
        {
            foreach(var i in a)
            {
                Console.WriteLine(i);
            }
        }
        public static int Test3(ref int x)
        {
            x = 15;
            return x;
        }
        public static void Test4(out int x, out int y)
        {
            x = 20;
            y = 30;
            Console.WriteLine($"{x} {y}");
        }
        public static int Test2(in int a)
        {
            return a + 5;
        }

    }
}
