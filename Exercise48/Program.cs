using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise48
{
    class Program
    {
        /*
        * Exercise 48
        * Description:
        * Prompt the user to enter as many numbers as they want.
        * Store these numbers in a list and output their sum.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 48";

            bool enterAgain = true;
            bool continueEnteringNumbers = true;
            List<double> numbersList = new List<double>();

            do
            {
                AddToNumbersList(numbersList, continueEnteringNumbers);

                // Find the sum of the numbers in the list
                double sumOfNumbersInList = numbersList.Sum();

                // Join all of the elements of the list with the plus symbol
                string listOfNumbersJoinedByPlus = String.Join(" + ", numbersList.ToArray());

                Console.WriteLine($"{listOfNumbersJoinedByPlus} = {numbersList.Sum()}");

                string continueInput = "";
                do // Loop for determining if the user wants to enter text again
                {
                    // Ask the user if they would like to continue
                    Console.Write("\nWould you like to continue (y/n)? ");
                    string userInput = Console.ReadLine();
                    continueInput = userInput;
                    if (continueInput.ToLower().Trim() == "y")
                    {
                        numbersList.Clear();
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

        // Add users numbers to a list
        public static void AddToNumbersList(List<double> numbersList, bool continueEnteringNumbers)
        {
            do
            {
                double userNumber = 0.0d;
                Console.Write("Enter a number (q to quit): ");
                string userInput = Console.ReadLine();
                if (userInput.ToLower().Trim() == "q")
                {
                    continueEnteringNumbers = false;
                }
                else
                {
                    try
                    {
                        userNumber = double.Parse(userInput);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a number.");
                    }
                    numbersList.Add(userNumber);
                }
            } while (continueEnteringNumbers == true);
        }
    }
}
