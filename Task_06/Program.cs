using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<(string a, int b)> x = new MyGenericClass<(string a, int b)>();
        }
    }
}
