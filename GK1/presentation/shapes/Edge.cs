using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class Edge : IMovable
    {
        public (Vertex p1, Vertex p2) EndsPair { get; set; }

        public Edge(Vertex p1, Vertex p2)
        {
            this.EndsPair = (p1, p2);
        }
        public void MoveAVector(int X, int Y)
        {
            EndsPair.p1.Position = (EndsPair.p1.Position.X + X, EndsPair.p1.Position.Y + Y);
            EndsPair.p2.Position = (EndsPair.p2.Position.X + X, EndsPair.p2.Position.Y + Y);
        }
    }
}
