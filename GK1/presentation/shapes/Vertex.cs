using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class Vertex : IPoint, IMovable
    {
        public (int X, int Y) Position { get; set; }
        public (Edge prev, Edge next) AdjacentEdges { get; set; }

        public Vertex(int X, int Y)
        {
            Position = (X, Y);
        }
        public double Distance(int X, int Y)
        {
            return Math.Abs(Position.X - X) + Math.Abs(Position.Y - Y);
        }
        public void MoveAVector(int X, int Y)
        {
            Position = (Position.X + X, Position.Y + Y);
        }
        public void MoveTo(int X, int Y)
        {
            Position = (X, Y);
        }
    }
}
