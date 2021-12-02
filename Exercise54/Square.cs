using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise54
{
    public class Square : Shape
    {
        private double sideLength;
        public double SideLength
        {
            get { return sideLength; }
            set { sideLength = value; }
        }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        /// <summary>
        /// Returns the perimeter of a square with a given side length.
        /// </summary>
        /// <param name="sideLength"></param>
        /// <returns></returns>
        public double CalculatePerimeter(double sideLength)
        {
            double squarePerimeter = 4 * sideLength;

            return squarePerimeter;
        }

        /// <summary>
        /// Returns the area of a square with a given side length.
        /// </summary>
        /// <param name="sideLength"></param>
        /// <returns></returns>
        public double CalculateArea(double sideLength)
        {
            double squareArea = Math.Pow(sideLength, 2);

            return squareArea;
        }

        public override bool IsClosed()
        {
            return true;
        }

        public override bool HasEdges()
        {
            return true;
        }
    }
}
