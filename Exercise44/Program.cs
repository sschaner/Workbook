using System;
using System.Linq;

namespace Exercise44
{
    class Program
    {
        /*
        * Exercise 44
        * Description:
        * Enhance the point class in the previous exercise by adding a CalculateMidpoint method.
        * The CalculateMidpoint will take as an argument another point and return the midpoint between the current
        * ('this') object and the point passed in. It's method signature will look like: Point CalculateMidpoint(Point other)
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 44";

            bool enterAgain = true;
            string userInput = "";
            int pointXValue = -1;
            int pointYValue = -1;

            do
            {
                Point midpoint = new Point(pointYValue, pointXValue);
                Point firstPoint = GetUsersPoint(userInput, pointXValue, pointYValue);
                Point secondPoint = GetUsersPoint(userInput, pointXValue, pointYValue);
                
                midpoint = midpoint.CalculateMidpoint(firstPoint, secondPoint);

                Console.WriteLine($"The midpoint between ({firstPoint.X},{firstPoint.Y}) and ({secondPoint.X},{secondPoint.Y}) is ({midpoint.X},{midpoint.Y}).");

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
        public static Point GetUsersPoint(string userInput, int pointXValue, int pointYValue)
        {
            Console.Write("Enter coordinates for a point: ");
            userInput = Console.ReadLine();
            int[] arrayOfPointValues = userInput.Trim().Split(' ').Select(Int32.Parse).ToArray();
            Point point = new Point(arrayOfPointValues[0], arrayOfPointValues[1]);
            return point;
        }
    }
}
