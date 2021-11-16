using System;
using System.Collections.Generic;

namespace Exercise50
{
    class Program
    {
        /*
        * Exercise 50
        * Description:
        * Create a list of triangles.
        * Use the Triangle class.
        * Display some statistics for the collection of triangles.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 50";
            string userInput = "";
            bool enterAgain = true;
            bool continueEnteringSideLength = true;
            List<double[]> trianglesList = new List<double[]>();
            Triangle triangle = new Triangle();

            do
            {
                AddToTrianglesList(userInput, trianglesList, continueEnteringSideLength);

                double sumOfAreas = 0.0d;
                double sumOfPerimeters = 0.0d;
                double areaOfEachTriangle = 0.0d;
                double perimeterOfEachTriangle = 0.0d;

                // Loop through the list of triangle arrays
                foreach (double[] triangleNumber in trianglesList)
                {
                    // Loop through each trangle array
                    for (int i = 0; i < triangleNumber.Length; i++)
                    {
                        areaOfEachTriangle = triangle.AreaOfTriangle(triangleNumber[0], triangleNumber[1]);
                        sumOfAreas = sumOfAreas + areaOfEachTriangle;
                        perimeterOfEachTriangle = triangle.PerimeterOfTriangle(triangleNumber[0], triangleNumber[1], triangleNumber[2]);
                    }
                    sumOfPerimeters = sumOfPerimeters + perimeterOfEachTriangle;

                }
                Console.WriteLine($"Average Area: {sumOfAreas / trianglesList.Count}");
                Console.WriteLine($"Average Perimeter: {sumOfPerimeters / trianglesList.Count}");

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

        public static void AddToTrianglesList(string userInput, List<double[]> trianglesList, bool continueEnteringSideLength)
        {
            do
            {
                double sideLength1 = 0.0d;
                double sideLength2 = 0.0d;
                double sideLength3 = 0.0d;

                Console.Write("Enter the side lengths of a triangle (q to quit): ");
                string[] userGivenSideLengths = Console.ReadLine().Split();
                if (userGivenSideLengths[0].ToLower() == "q")
                {
                    continueEnteringSideLength = false;
                }
                else if (userGivenSideLengths.Length <3)
                {
                    Console.WriteLine("You must enter 3 sides. A triangle has 3 sides.");
                }
                else
                {
                    // Parse elements as ints to get each side length
                    bool isValidNumber1 = double.TryParse(userGivenSideLengths[0], out sideLength1);
                    bool isValidNumber2 = double.TryParse(userGivenSideLengths[1], out sideLength2);
                    bool isValidNumber3 = double.TryParse(userGivenSideLengths[2], out sideLength3);

                    if (isValidNumber1 == true && isValidNumber2 == true && isValidNumber3 == true)
                    {
                        // Create a temporary array to store the side lengths in
                        double[] tempTriangle = new double[3];

                        // Add the side lengths to the temporary array
                        tempTriangle[0] = sideLength1;
                        tempTriangle[1] = sideLength2;
                        tempTriangle[2] = sideLength3;

                        // add the temporary array to the triangles list
                        trianglesList.Add(tempTriangle);
                    }
                }

            } while (continueEnteringSideLength == true);
        }

    }
}
