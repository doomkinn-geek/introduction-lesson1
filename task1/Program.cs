using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var uName = Environment.UserName;
            Console.WriteLine($"Привет, {uName}, сегодня {System.DateTime.Now:dd.MM.yyyy}");
        }
    }
}
