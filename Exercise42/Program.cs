using System;

namespace Exercise42
{
    class Program
    {
        /*
        * Exercise 42
        * Description:
        * Create a class called Point, that has two properties, X and Y.
        * Let the user enter an X and Y value to create a Point object.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 42";

            bool enterAgain = true;

            do
            {
                Console.Write("Enter an X coordinate: ");
                int xCoordinate = int.Parse(Console.ReadLine());
                Console.Write("Enter a Y coordinate: ");
                int yCoordinate = int.Parse(Console.ReadLine());

                Point point = new Point(xCoordinate, yCoordinate);

                Console.WriteLine($"You have created a point object ({point.X},{point.Y}).");

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
    }
}
