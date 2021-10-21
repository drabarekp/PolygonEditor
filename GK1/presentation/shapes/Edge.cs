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
        public double Length {
            get => EndsPair.p1.Distance(EndsPair.p2.Position.X, EndsPair.p2.Position.Y);
                }
        public (double X, double Y) UnitVector12 {
            get => ((EndsPair.p2.Position.X - EndsPair.p1.Position.X) / Length, (EndsPair.p2.Position.Y - EndsPair.p1.Position.Y) / Length);
                }
        public (double X, double Y) UnitVector21
        {
            get => (-UnitVector12.X, -UnitVector12.Y);
        }
        public (double X, double Y) UnitVectorPerpendicular
        {
            get => (UnitVector12.Y, -UnitVector12.X);
        }


        public Edge(Vertex p1, Vertex p2)
        {
            this.EndsPair = (p1, p2);
        }
        public Relation relation;
        public void MoveAVector(int X, int Y, List<Edge> alreadyVisited = null, List<Vertex> alreadyMovedVertices = null)
        {
            EndsPair.p1.MoveAVector(X, Y);
            EndsPair.p2.MoveAVector(X, Y);
        }
        public Vertex GetAnotherEnd(Vertex oneEnd)
        {
            if (EndsPair.p1 == oneEnd) return EndsPair.p2;
            if (EndsPair.p2 == oneEnd) return EndsPair.p1;
            return null;
        }
        public double DistanceToPoint((int X, int Y) point)
        {
            int x1 = EndsPair.p1.Position.X, y1 = EndsPair.p1.Position.Y, x2 = EndsPair.p2.Position.X, y2 = EndsPair.p2.Position.Y;
            int x0 = point.X, y0 = point.Y;

            return (Math.Abs((x2 - x1) * (y1 - y0) - (x1 - x0) * (y2 - y1))) / (Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
        }
       
    }
}
