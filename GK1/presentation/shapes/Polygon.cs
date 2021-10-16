using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class Polygon
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
    }
}
