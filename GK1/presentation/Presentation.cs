using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class Presentation
    {
        public List<Polygon> Polygons { get; set; }
        public List<Circle> Circles { get; set; }
        public (int X, int Y) Size { get; set; }

        public Presentation(string str)
        {
            Polygons = new List<Polygon>();
            Circles = new List<Circle>();
            Size = (1000, 1000);

            if(str == "test")
            {
                /*Polygons.Add(new Polygon(new Vertex[] {
                    new Vertex(100, 120),
                    new Vertex(400, 300),
                    new Vertex(600, 400)
                }));*/
            }
        }
        public (Vertex, Polygon) PolygonClose(int X, int Y)
        {
            foreach (var p in Polygons)
            {
                var v = p.VertexClose(X, Y);
                if (v != null) return (v, p);
            }
            return (null, null);
        }
        public Circle CircleClose(int X, int Y)
        {
            const int close = 10;
            foreach (var c in Circles)
            {
                if (c.DistanceFromCenter(X, Y) < close)
                {
                    return c;
                }
            }
            return null;
        }
        public (Edge, Polygon) EdgeClose(int X, int Y)
        {
            foreach(var p in Polygons)
            {
                var (edge, polygon) = p.WasEdgeClose(X, Y);
                if (edge != null) return (edge, polygon);
            }
            return (null, null);
        }
    }
}
