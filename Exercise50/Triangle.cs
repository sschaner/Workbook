using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise50
{
    public class Triangle
    {
        private int sideLength1 { get; set;}
        public int SideLength1
        {
            get { return sideLength1; }
            set { sideLength1 = SideLength1; }
        }
        private int sideLength2 { get; set; }
        public int SideLength2
        {
            get { return sideLength2; }
            set { sideLength2 = SideLength2; }
        }
        private int sideLength3 { get; set; }
        public int SideLength3
        {
            get { return sideLength3; }
            set { sideLength3 = SideLength3; }
        }

        public double AreaOfTriangle (int sideLength1, int sideLength2)
        {
            double areaOfTriangle = (sideLength1 + sideLength2) / 2;
            return areaOfTriangle;
        }

        public double PerimeterOfTriangle (int sideLength1, int sideLength2, int sideLength3)
        {
            double perimeterOfTriangle = sideLength1 + sideLength2 + sideLength3;
            return perimeterOfTriangle;
        }
    }
}
