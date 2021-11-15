using System;
using System.Collections.Generic;

namespace Exercise50
{
    class Program
    {
        /*
        * Exercise 50
        * 
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
            List<int[]> trianglesList = new List<int[]>();
            

            AddToTrianglesList(userInput, trianglesList, continueEnteringSideLength);

            Console.ReadKey();
        }

        public static void AddToTrianglesList(string userInput, List<int[]> trianglesList, bool continueEnteringSideLength)
        {
            do
            {
                int sideLength1 = -1;
                int sideLength2 = -1;
                int sideLength3 = -1;

                Console.Write("Enter the side lengths of a triangle (q to quit): ");
                string[] userGivenSideLengths = Console.ReadLine().Split();
                if (userGivenSideLengths[0].ToLower() == "q")
                {
                    continueEnteringSideLength = false;
                }
                else
                {
                    // Parse elements as ints to get each side length
                    bool isValidNumber1 = int.TryParse(userGivenSideLengths[0], out sideLength1);
                    bool isValidNumber2 = int.TryParse(userGivenSideLengths[1], out sideLength2);
                    bool isValidNumber3 = int.TryParse(userGivenSideLengths[2], out sideLength3);

                    if (isValidNumber1 == true && isValidNumber2 == true && isValidNumber3 == true)
                    {
                        // Create a temporary array to store the side lengths in
                        int[] tempTriangle = new int[3];

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
