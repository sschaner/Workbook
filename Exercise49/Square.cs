using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise49
{
    /*
     * Create a list of squares.
     * Use the Square class you built in Lab 9.
     * Then display some statistics for the collection of squares
     */
    public class Square
    {
        private int sideLength { get; set; }
        public int SideLength
        {
            get { return sideLength; }
            set { sideLength = SideLength; }
        }

        public int AreaOfSquare(int sideLength)
        {
            int area = sideLength * sideLength;
            return area;
        }

        public int PerimeterOfSquare(int sideLength)
        {
            int perimeter = 4 * sideLength;
            return perimeter;
        }


    }
}
