using System;
using System.Linq;

namespace Exercise39
{
    class Program
    {
        /*
        * Exercise 39
        * Description:
        * Prompt the user to enter five numbers.
        * Store these numbers in an array and output them in ascending order.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 39";

            bool enterAgain = true;

            do
            {
                // Prompt the user to enter five numbers
                Console.Write("Enter a number: ");
                int userNumberOne = int.Parse(Console.ReadLine());
                Console.Write("Enter a number: ");
                int userNumberTwo = int.Parse(Console.ReadLine());
                Console.Write("Enter a number: ");
                int userNumberThree = int.Parse(Console.ReadLine());
                Console.Write("Enter a number: ");
                int userNumberFour = int.Parse(Console.ReadLine());
                Console.Write("Enter a number: ");
                int userNumberFive = int.Parse(Console.ReadLine());

                double[] userNumberArray = AddNumbersToArray(userNumberOne, userNumberTwo, userNumberThree, userNumberFour, userNumberFive);

                // Sort the array
                Array.Sort(userNumberArray);
                // Print each element of the array on one line
                for (int i = 0; i < userNumberArray.Length; i++)
                {
                    if (i == userNumberArray.Length - 1)
                    {
                        Console.Write($"{userNumberArray[i]}");
                    }
                    else
                    {
                        Console.Write($"{userNumberArray[i]} ");
                    }
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

        public static double[] AddNumbersToArray(int userNumberOne, int userNumberTwo, int userNumberThree, int userNumberFour, int userNumberFive)
        {
            double[] userNumberArray = new double[5];
            userNumberArray[0] = userNumberOne;
            userNumberArray[1] = userNumberTwo;
            userNumberArray[2] = userNumberThree;
            userNumberArray[3] = userNumberFour;
            userNumberArray[4] = userNumberFive;

            return userNumberArray;
        }
    }
}
