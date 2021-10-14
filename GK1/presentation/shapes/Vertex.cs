﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class Vertex : IPoint
    {
        public (int X, int Y) Position { get; set; }

        public Vertex(int X, int Y)
        {
            Position = (X, Y);
        }
        public double Distance(int X, int Y)
        {
            return Math.Abs(Position.X - X) + Math.Abs(Position.Y - Y);
        }
    }
}
