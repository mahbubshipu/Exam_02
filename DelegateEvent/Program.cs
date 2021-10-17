using System;

namespace DelegateEvent
{
    class Program
    {
        public delegate void MyActivity(object expectedvalue);
        static void Main(string[] args)
        {
            MyActivity myActivity = PrintAfter;
            Dosomething(5, myActivity);

        }
        public static void Dosomething(int x, MyActivity activity)
        {
            activity(x);
        }
        public static void Print(object item)
        {
            Console.WriteLine(item);
        }
        public static void PrintAfter(object item)
        {
            Console.WriteLine(item);
            Console.WriteLine("==============");
            Console.WriteLine("==============");
           

        }
    }
}
