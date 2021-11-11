using System;

namespace Exercise32
{
    /*
     * Exercise 32
     * 
     * Description:
     * Create an array of size 5 with the following numbers: 2, 8, 0, 24, 51
     * Prompt the user to enter an index.
     * If the number is in the array, display the index at which it is located.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 32";

            int[] numbersArray = { 2, 8, 0, 24, 51 };

            bool enterAgain = false;
            do // Loops as long as the user wants to enter some text
            {
                
                try
                {
                    int userChosenNumber = int.Parse(EnterANumber());
                    bool numberFound = false;
                    for (int i = 0; i < numbersArray.Length; i++)
                    {
                        if (userChosenNumber == numbersArray[i])
                        {
                            numberFound = true;
                            Console.WriteLine($"The value {userChosenNumber} can be found at index {i}.");
                        }
                    }
                    if (numberFound == false)
                    {
                        Console.WriteLine("The value cannot be found in the array.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("The value cannot be found in the array. ");
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

        // Ask the user to enter a number
        public static string EnterANumber()
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            return userInput;
        }
    }
}
