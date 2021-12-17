using System;

namespace Exercise59
{
    class Program
    {
        /*
        * Exercise 59
        * Description:
        * Define a card class with two properties, Rank and Suit.
        * For these properties, define two enums,
        * Rank (Ace, King, Queen, etc.) and Suit (Spades, Diamonds, Hearts, Clubs)
        */
        static void Main(string[] args)
        {
            Title();

            Exit();
        }

        public static void Title()
        {
            Console.Title = "Exercise 59";
        }

        public static void Exit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
