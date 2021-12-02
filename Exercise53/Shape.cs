using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise53
{
    public abstract class Shape
    {

        // This method returns whether the figure is closed or not. It must be inherited with logic
        public abstract bool IsClosed();

        // Returns whether the shape has edges. Must be overwritten with logic
        public abstract bool HasEdges();

    }
}
