using System;

namespace Exercise58
{
    class Program
    {
        static void Main(string[] args)
        {
            Title();

            Exit();
        }

        public static void Title()
        {
            Console.Title = "Exercise 58";
        }

        public static void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
