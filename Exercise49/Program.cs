using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise49
{
    class Program
    {
        /*
        * Exercise 49
        * 
        * Description:
        * Create a list of squares.
        * Use the Square class.
        * Display some statistics for the collection of squares.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 49";

            string userInput = "";
            bool enterAgain = true;
            do
            {
                bool continueEnteringSideLength = true;
                List<int> squaresList = new List<int>();
                AddToSquaresList(userInput, squaresList, continueEnteringSideLength);

                Square square = new Square();

                double sumOfAreas = 0;
                double sumOfPerimeters = 0;
                for (int i = 0; i < squaresList.Count; i++)
                {
                    sumOfAreas = sumOfAreas + square.AreaOfSquare(squaresList[i]);
                    Math.Round(sumOfAreas, 2);
                    sumOfPerimeters = sumOfPerimeters + square.PerimeterOfSquare(squaresList[i]);
                }

                double averageArea = Math.Round((sumOfAreas / squaresList.Count()), 2);
                double averagePerimeter = Math.Round((sumOfPerimeters / squaresList.Count()), 2);

                Console.WriteLine($"You created {squaresList.Count()} squares.");
                Console.WriteLine($"Largest: {squaresList.Max()}");
                Console.WriteLine($"Smallest: {squaresList.Min()}");
                Console.WriteLine($"Average Area: {averageArea}");
                Console.WriteLine($"Average Perimeter: {averagePerimeter}");

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

        public static void AddToSquaresList (string userInput, List<int> squaresList, bool continueEnteringSideLength)
        {
            do
            {
                int sideLength = -1;
                Console.Write("Enter a side length (q to quit): ");
                userInput = Console.ReadLine();
                bool isValidNumber = int.TryParse(userInput, out sideLength);
                if (isValidNumber == true)
                {
                    squaresList.Add(sideLength);
                }

                if (userInput.ToLower().Trim() == "q")
                {
                    continueEnteringSideLength = false;
                }
            } while (continueEnteringSideLength == true);
        }

    }
}
