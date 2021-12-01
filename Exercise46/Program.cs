using System;
using System.Linq;

namespace Exercise46
{
    class Program
    {
        /*
        * Exercise 46
        * Description:
        * Create a class Triangle, that has three properties, Side1Length, Side2Length, Side3Length.
        * The class should have two methods, CalculatePerimeter and CalculateArea.
        * Let the user enter the length of the triangle's sides.
        * Create an object based on those lengths and output the triangle's detals.
        * Hint: Google Heron's Formula
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 46";

            string userInput = "";
            bool enterAgain = true;

            do
            {
                TriangleStart:
                Console.Write("Enter the side lengths of a triangle: ");
                userInput = Console.ReadLine();
                double[] arrayOfSideLengths = GetUsersThreeChosenSideLengths(userInput);
                // Set the users chosen indices to variables
                double side1Length = arrayOfSideLengths[0];
                double side2Length = arrayOfSideLengths[1];
                double side3Length = arrayOfSideLengths[2];

                Triangle triangle = new Triangle(side1Length, side2Length, side3Length);
                // Check if the given sides will create a triangle
                if (double.IsNaN(triangle.CalculateArea(side1Length, side2Length, side3Length)) == true)
                {
                    Console.WriteLine("Your chosen side lengths do not form a triangle. Please try again.");
                    goto TriangleStart;
                }
                else
                {
                    Console.WriteLine($"The triangle has side lengths of {triangle.Side1Length}, {triangle.Side2Length}, and {triangle.Side3Length}. Its area is {triangle.CalculateArea(side1Length, side2Length, side3Length)} and its perimeter is {triangle.CalculatePerimeter(side1Length, side2Length, side3Length)}.");
                }

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

        // Get the users two entered indices separated by a space
        public static double[] GetUsersThreeChosenSideLengths(string userInput)
        {
            double[] arrayOfSideLengths = userInput.Trim().Split(' ').Select(double.Parse).ToArray();
            return arrayOfSideLengths;
        }
    }
}
