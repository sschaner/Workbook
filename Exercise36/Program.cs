using System;

namespace Exercise36
{
    class Program
    {
        /*
        * Exercise 36
        * Description:
        * Create two arrays, each of size 5.
        * Fill the first array with the numbers: 12, 11, 10, 9, 8.
        * Fill the second array with the strings: "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking".
        * Combine both arrays to display a piece of the Christmas song.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 36";

            string userInput = "";
            string isSinging = "";
            int[] songNumbers = new int[5] { 12, 11, 10, 9, 8 };
            string[] songWords = new string[5] { "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking" };

            do
            {
                Console.Write("Enter a command (sing/quit): ");
                userInput = Console.ReadLine();
                isSinging = DetermineIfSinging(userInput);
                // isQuitting = DetermineIfQuitting(userInput);
                if (isSinging == "sing")
                {
                    for (int i = 0; i < songNumbers.Length; i++)
                    {
                        Console.WriteLine($"{songNumbers[i]} {songWords[i]}");
                    }
                }
                else if (isSinging == "quit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine(isSinging);
                }
            } while (isSinging != "quit");

            

            Console.ReadKey();
        }

        // Determine if the user wants to sing
        static string DetermineIfSinging(string userInput)
        {
            if (userInput.ToLower().Trim() == "sing")
            {
                return "sing";
            }
            else if (userInput.ToLower().Trim() == "quit")
            {
                return "quit";
            }
            else
            {
                return "Please enter either 'sing' or 'quit'.";
            }
        }

        // Determine if the user wants to quit
        static bool DetermineIfQuitting(string userInput)
        {
            if (userInput.ToLower().Trim() == "quit")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
