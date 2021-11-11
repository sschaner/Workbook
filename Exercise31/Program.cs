using System;

namespace Exercise31
{
    class Program
    {
        /*
        * Exercise 31
        * 
        * Description:
        * Create an array of size 5 with the following numbers: 2, 8, 0, 24, 51
        * Prompt the user to enter an index.
        * Display the element in the array at that index.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 31";

            int[] numbersArray = { 2, 8, 0, 24, 51 };

            bool enterAgain = false;
            do // Loops as long as the user wants to enter some text
            {
                int userChosenIndex = int.Parse(EnterIndexOfArray());
                try
                {
                    Console.WriteLine($"The value at index {userChosenIndex} is {numbersArray[userChosenIndex]}.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That is not a valid index.");
                }                

                string continueInput = "";
                do // Loop for determining if the user wants to enter text again
                {
                    // Ask the user if they would like to continue
                    Console.Write("\nWould you like to continue (y/n)? ");
                    string userInput = Console.ReadLine();
                    continueInput = userInput;
                    if (continueInput.ToLower().Trim() == "y")
                    {
                        enterAgain = true;
                    }
                    else if (continueInput.ToLower().Trim() == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        enterAgain = false;
                        goto Exit;
                    }
                    else
                    {
                        Console.WriteLine("Please enter either 'y' or 'n'");
                    }
                } while (continueInput.ToLower().Trim() != "y");

            } while (enterAgain == true);

            Exit:

            Console.ReadKey();
        }

        // Ask the user to enter an index
        public static string EnterIndexOfArray()
        {
            Console.Write("Enter an index of the array: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
