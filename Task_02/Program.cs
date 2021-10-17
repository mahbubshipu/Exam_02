using System;
using System.Text;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var stringBuldar = new StringBuilder();
            stringBuldar.AppendLine("<body>");
            for(var i=0;i<number; i++)
            {
                stringBuldar.AppendLine("<h1>");
                stringBuldar.AppendLine(Console.ReadLine());
                stringBuldar.AppendLine("</h1>");
            }
            stringBuldar.AppendLine("</body>");
            var text = stringBuldar.ToString();
            Console.WriteLine(text);
        }
    }
}
