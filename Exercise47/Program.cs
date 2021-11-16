using System;
using System.Collections.Generic;

namespace Exercise47
{
    class Program
    {
        /*
        * Exercise 47
        * Description:
        * Prompt the user to enter a string.
        * Store the string in a list and display the contents of the list with each element separated by a space.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 47";

            string userInput = "";
            bool enterAgain = true;
            List<string> userStringList = new List<string>();

            do
            {
                string userText = GetUserString();
                string[] userTextAsArray = ConvertUserStringToArrayOfWords(userText);
                AddToStringList(userTextAsArray, userStringList);
                string joined = String.Join(" ", userStringList.ToArray());
                Console.WriteLine($"You have entered: {joined}");

                string continueInput = "";
                do // Loop for determining if the user wants to enter text again
                {
                    // Ask the user if they would like to continue
                    Console.Write("\nWould you like to continue (y/n)? ");
                    userInput = Console.ReadLine();
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

        // Get the text from the user
        public static string GetUserString()
        {
            string userString = "";
            Console.Write("Enter some text: ");
            userString = Console.ReadLine().Trim();
            return userString;
        }

        // Convert the user's text to an array of words
        public static string[] ConvertUserStringToArrayOfWords(string userString)
        {
            string[] userTextAsArray = userString.Split();

            return userTextAsArray;
        }

        // Add the array of words to the list
        public static void AddToStringList(string[] userTextAsArray, List<string> usersStringList)
        {
            for (int i = 0; i < userTextAsArray.Length; i++)
            {
                usersStringList.Add(userTextAsArray[i]);
            }
        }
    }
}
