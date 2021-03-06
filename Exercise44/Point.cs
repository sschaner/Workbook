using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise44
{
    public class Point
    {
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double distanceFromOrigin(int x, int y)
        {
            double distanceFromOrigin = 0.0d;

            distanceFromOrigin = Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2));

            return distanceFromOrigin;
        }

        public Point CalculateMidpoint(Point pointOne, Point pointTwo)
        {
            int xMidpointValue = (pointOne.x + pointTwo.x) / 2;
            int yMidpointValue = (pointOne.y + pointTwo.y) / 2;
            Point midpoint = new Point(xMidpointValue, yMidpointValue);

            return midpoint;
        }
    }
}
