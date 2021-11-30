﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise42
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
    }
}
