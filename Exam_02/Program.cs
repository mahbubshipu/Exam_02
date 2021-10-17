using System;

namespace Exam_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("Umma", "Ajery");
            Print("Mahbubul", "Alom", "Shipu");
        }
        public static void Print(params string[] texts)
        {
            foreach(var text in texts)
            {
                Console.WriteLine(text);
            }
        }
    }
}
