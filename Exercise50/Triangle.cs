using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise50
{
    public class Triangle
    {
        private double sideLength1 { get; set;}
        public double SideLength1
        {
            get { return sideLength1; }
            set { sideLength1 = SideLength1; }
        }
        private double sideLength2 { get; set; }
        public double SideLength2
        {
            get { return sideLength2; }
            set { sideLength2 = SideLength2; }
        }
        private double sideLength3 { get; set; }
        public double SideLength3
        {
            get { return sideLength3; }
            set { sideLength3 = SideLength3; }
        }

        public double AreaOfTriangle (double sideLength1, double sideLength2)
        {
            double areaOfTriangle = (sideLength1 + sideLength2) / 2;
            return areaOfTriangle;
        }

        public double PerimeterOfTriangle (double sideLength1, double sideLength2, double sideLength3)
        {
            double perimeterOfTriangle = sideLength1 + sideLength2 + sideLength3;
            return perimeterOfTriangle;
        }
    }
}
