using System;

namespace Exercise33
{
    /*
     * Exercise 33
     * 
     * Description:
     * Create an array of size 5 with the following numbers: 2, 8, 0, 24, 51
     * Let the user change the array by specifying an index and a replacement number.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 31";

            int[] numbersArray = { 2, 8, 0, 24, 51 };

            bool enterAgain = false;
            do // Loops as long as the user wants to enter some text
            {
                string continueInput = "";
                int userChosenIndex = EnterIndexOfArray();
                try
                {
                    bool userInputIsValid = false;
                    Console.Write($"The value at index {userChosenIndex} is {numbersArray[userChosenIndex]}. ");
                    Console.Write("Would you like to change it (y/n)? ");
                    string userInput = Console.ReadLine();
                    do
                    {
                        Console.Write($"Enter the new value at index {userChosenIndex}: ");
                        int userNewIndexValue = int.Parse(Console.ReadLine());
                        numbersArray[userChosenIndex] = userNewIndexValue;
                        Console.WriteLine($"The value at index {userChosenIndex} is {numbersArray[userChosenIndex]}.");
                        if (userInput.ToLower().Trim() == "y")
                        {
                            userInputIsValid = true;
                        }
                        else if (userInput.ToLower().Trim() == "n")
                        {
                            Console.WriteLine("Goodbye!");
                            goto Exit;
                        }
                        else
                        {
                            Console.WriteLine("Please enter either 'y' or 'n'");
                        }
                    } while (userInputIsValid == false);

                    
                    
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That is not a valid index.");
                }

                
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
        public static int EnterIndexOfArray()
        {
            Console.Write("Enter an index of the array: ");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
    }
}
