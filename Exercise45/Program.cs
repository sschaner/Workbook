using System;

namespace Exercise45
{
    class Program
    {
        /*
        * Exercise 45
        * Description:
        * Create a class Square, that has one property, SideLength.
        * The class should have two methods, CalculatePerimeter and CalculateArea.
        * Let the user enter the length of the square's side.
        * Create an object based on that length and output details of the square.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 45";  

            bool enterAgain = true;

            do
            {
                Console.Write("Enter a side length: ");
                double sideLength = double.Parse(Console.ReadLine());

                Square square = new Square(sideLength);

                Console.WriteLine($"The square has a side length {square.SideLength}. Its area is {square.CalculateArea(sideLength)} and its perimeter is {square.CalculatePerimeter(sideLength)}.");

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
