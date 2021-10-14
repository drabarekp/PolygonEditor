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
        public List<Edge> Edges { get; set; }
        public Polygon()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }
        public Polygon(IEnumerable<Vertex> vertices)
        {
            Vertices = vertices.ToList();
            Edges = new List<Edge>();

            Vertex v1 = null, v2 = null;

            
            foreach(var v in vertices)
            {
                v1 = v2;
                v2 = v;
                if (v1 != null)
                    Edges.Add(new Edge(v1, v2));
            }
            Edges.Add(new Edge(v2, vertices.First()));
        }

        public void AddVertex(Vertex v)
        {
            Vertices.Add(v);
            if(Edges.Count>0) Edges.RemoveAt(Edges.Count - 1);
            if (Vertices.Count > 1)
            {
                Edges.Add(new Edge(Vertices[^2], Vertices[^1]));
                Edges.Add(new Edge(Vertices[^1], Vertices[0]));
            }
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
