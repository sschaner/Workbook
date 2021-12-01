using System;
using System.Linq;

namespace Exercise35
{
    class Program
    {
        /*
        * Exercise 35
        * Description:
        * Create an array of size 5 and fill it with the following strings: "cow", "elephant", "jaguar", "horse", "crow".
        * Prompt the user to enter two indices separated by a space.
        * The first index will specify the word and the second will specify a letter in that word.
        * Display the corresponding word and letter.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 35";

            string userInput = "";
            bool enterAgain = false;

            do // Loop through the application logic if the user wants to enter indices again
            {
                // Create an array of size 5 and fill it with the following strings: "cow", "elephant", "jaguar", "horse", "crow"
                string[] animalArray = new string[] { "cow", "elephant", "jaguar", "horse", "crow" };

                try
                {
                    int[] arrayOfIndices = GetUsersTwoChosenIndices(userInput);
                    // Set the users chosen indices to variables
                    int usersFirstChosenIndex = arrayOfIndices[0];
                    int usersSecondChosenIndex = arrayOfIndices[1];

                    // Create two sentences
                    string sentenceOne = $"The value at index {usersFirstChosenIndex} is {animalArray[usersFirstChosenIndex]}.";
                    string sentenceTwo = $"The letter at index {usersSecondChosenIndex} is {animalArray[usersFirstChosenIndex][usersSecondChosenIndex]}.";
                    // Print the two sentences to the Console
                    Console.WriteLine($"{sentenceOne} {sentenceTwo}");   
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Those are not valid indices.");
                }

                string continueInput = "";
                do // Loop for determining if the user wants to continue
                {
                    // Ask the user if they would like to continue
                    Console.Write("Continue (y/n)? ");
                    userInput = Console.ReadLine();
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
                        Console.WriteLine("Please enter valid input.");
                        continue;
                    }
                } while (continueInput.ToLower().Trim() != "y");
                Console.Clear();


            } while (enterAgain == true);

            Exit:

            Console.ReadKey();
        }

        // Get the users two entered indices separated by a space
        public static int[] GetUsersTwoChosenIndices (string userInput)
        {
            Console.Write("Enter two indices: ");
            userInput = Console.ReadLine();
            int[] arrayOfIndices = userInput.Trim().Split(' ').Select(Int32.Parse).ToArray();
            return arrayOfIndices;
        }
    }
}
