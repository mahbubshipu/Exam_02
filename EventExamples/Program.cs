using System;

namespace EventExamples
{
    class Program
    {
        public delegate void Notification(string message);
        public static event Notification notificationevent;
        static void Main(string[] args)
        {
            notificationevent += Program_notificationevent;
            notificationevent += Program_notificationevent1;
            notificationevent += Program_notificationevent2;
            notificationevent("Executed");
        }

        private static void Program_notificationevent2(string message)
        {
            Console.WriteLine(message+"Savar a jabe");
        }

        private static void Program_notificationevent1(string message)
        {
            Console.WriteLine(message + "Mirpur  a jabe");
        }

        private static void Program_notificationevent(string message)
        {
            Console.WriteLine(message + "Kushtia a jaben");
        }
    }
}
