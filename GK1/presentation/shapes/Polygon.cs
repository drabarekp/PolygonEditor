using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class Polygon : IMovable
    {
        public List<Vertex> Vertices { get; set; }
        //public List<Edge> Edges { get; set; }
        public Polygon()
        {
            Vertices = new List<Vertex>();
        }
        public void AddVertex(Vertex v)
        {
            Vertices.Add(v);
            var eNext = new Edge(v, Vertices[0]);
            if (Vertices.Count > 1)
            {
                var ePrev = new Edge(Vertices[^2], v);
                Vertices[^2].AdjacentEdges = (Vertices[^2].AdjacentEdges.prev, ePrev);
                v.AdjacentEdges = (ePrev, eNext);
            }
            Vertices[0].AdjacentEdges = (eNext, Vertices[0].AdjacentEdges.next);
        }
        public Vertex VertexClose(int X, int Y)
        {
            const int close = 10;
            foreach(var v in Vertices)
            {
                if(v.Distance(X, Y) < close)
                {
                    return v;
                }
            }

            return null;
        }
        public void MoveAVector(int X, int Y, List<Edge> alreadyVisited = null, List<Vertex> alreadyMovedVertices = null)
        {
            if (alreadyVisited == null)
            {
                alreadyVisited = new List<Edge>();
            }
            foreach(var v in Vertices)
            {
                v.MoveAVector(X, Y, alreadyVisited);
            }
        }
        public (Edge edge, Polygon polygon) WasEdgeClose(int X, int Y)
        {
            const int close = 5;
            int x0 = X;
            int y0 = Y;

            foreach (var v in Vertices)
            {
                var e = v.AdjacentEdges.prev;

                int x1 = e.EndsPair.p1.Position.X;
                int y1 = e.EndsPair.p1.Position.Y;
                int x2 = e.EndsPair.p2.Position.X;
                int y2 = e.EndsPair.p2.Position.Y;


                int xMin = Math.Min(x1, x2);
                int xMax = Math.Max(x1, x2);
                int yMin = Math.Min(y1, y2);
                int yMax = Math.Max(y1, y2);
                if (X < xMin) continue;
                if (X > xMax) continue;
                if (Y < yMin) continue;
                if (Y > yMax) continue;

                double distanceToLine = (Math.Abs((x2 - x1) * (y1 - y0) - (x1 - x0) * (y2 - y1)) / (Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1))));
                if (distanceToLine > close) continue;

                return (e, this);
            }

            return (null, null);
        }
    }
}
