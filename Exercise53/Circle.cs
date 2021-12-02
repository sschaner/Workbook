using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise53
{
    public class Circle : Shape
    {
        public double radius;
        private double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;

            return circumference;
        }

        public double CalculateArea(double radius)
        {
            double area = Math.Round(Math.PI * Math.Pow(radius, 2), 2, MidpointRounding.AwayFromZero);

            return area;
        }

        public override bool IsClosed()
        {
            return true;
        }

        public override bool HasEdges()
        {
            return false;
        }
    }
}
