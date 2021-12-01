using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise52
{
    class Program
    {
        /*
        * Exercise 52
        * Description:
        * Prompt the user to enter data for a collection of shapes.
        * Display aggregate information about the shapes.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 52";

            string userShapeChoice = "";
            string userInput = "";
            bool enterAgain = true;
            List<Shape> listOfShapes = new List<Shape>();
            List<double> listOfAreas = new List<double>();
            List<double> listOfPerimeters = new List<double>();

            do
            {
                Console.Write("Enter a shape. Square (1), Triangle (2), Circle (3), Quit (q): ");
                userShapeChoice = Console.ReadLine();
                do
                {
                    switch (userShapeChoice.ToLower().Trim())
                    {
                        case "1":
                        case "square":
                            Console.Write("Enter a side length: ");
                            double squareSideLength = int.Parse(Console.ReadLine());
                            Square square = new Square(squareSideLength);
                            listOfShapes.Add(square);
                            listOfAreas.Add(square.CalculateArea(squareSideLength));
                            listOfPerimeters.Add(square.CalculatePerimeter(squareSideLength));
                            break;
                        case "2":
                        case "triangle":
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
                                listOfShapes.Add(triangle);
                                listOfAreas.Add(triangle.CalculateArea(side1Length, side2Length, side3Length));
                                listOfPerimeters.Add(triangle.CalculatePerimeter(side1Length, side2Length, side3Length));
                            }
                            break;
                        case "3":
                        case "circle":
                            Console.Write("Enter the radius: ");
                            double circleRadius = int.Parse(Console.ReadLine());
                            Circle circle = new Circle(circleRadius);
                            listOfShapes.Add(circle);
                            listOfAreas.Add(circle.CalculateArea(circleRadius));
                            listOfPerimeters.Add(circle.CalculateCircumference(circleRadius));
                            break;
                        default:
                            break;
                    }
                    Console.Write("Enter a new shape. Square (1), Triangle (2), Circle (3), Quit (q): ");
                    userShapeChoice = Console.ReadLine();
                } while (userShapeChoice.ToLower().Trim() != "q");

                Console.WriteLine($"Average area: {Math.Round(listOfAreas.Average(), 2, MidpointRounding.AwayFromZero)}");
                Console.WriteLine($"Average perimeter: {Math.Round(listOfPerimeters.Average(), 2, MidpointRounding.AwayFromZero)}");

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
