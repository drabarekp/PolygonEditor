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

        //Size - (width x height) of view of the simulation
        public (int X, int Y) Size { get; set; }

        public Presentation(string str)
        {
            Polygons = new List<Polygon>();
            Circles = new List<Circle>();
            Size = (1000, 1000);

            InitializeDefaultSetup();
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
        
        //returns edge and its polygon near the point (X, Y)
        public (Edge, Polygon) EdgeClose(int X, int Y)
        {
            foreach(var p in Polygons)
            {
                var (edge, polygon) = p.WasEdgeClose(X, Y);
                if (edge != null) return (edge, polygon);
            }
            return (null, null);
        }
        public void InitializeDefaultSetup()
        {
            var p1 = new Polygon();
            var p2 = new Polygon();
            var c1 = new Circle((500, 500), 50);
            var c2 = new Circle((100, 300), 70);
            p1.AddVertex(new Vertex(100, 200));
            p1.AddVertex(new Vertex(200, 200));
            p1.AddVertex(new Vertex(400, 50));

            p2.AddVertex(new Vertex(800, 200));
            p2.AddVertex(new Vertex(750, 400));
            p2.AddVertex(new Vertex(650, 600));
            p2.AddVertex(new Vertex(400, 550));

            TangentRelation tang = new TangentRelation();

            tang.circle = c1;
            tang.edge = p2.Vertices[3].AdjacentEdges.prev;
            c1.edgeCircleRelations.Add(tang);
            tang.edge.relation = tang;
            tang.InitializeRelation();

            TangentRelation tang2 = new TangentRelation();
            tang2.circle = c2;
            tang2.edge = p1.Vertices[1].AdjacentEdges.prev;
            tang2.circle.edgeCircleRelations.Add(tang2);
            tang2.edge.relation = tang2;
            tang2.InitializeRelation();

            EqualLengthsRelation eqrel = new EqualLengthsRelation();
            eqrel.edges = (p2.Vertices[1].AdjacentEdges.prev, p1.Vertices[2].AdjacentEdges.prev);
            eqrel.edges.e1.relation = eqrel;
            eqrel.edges.e2.relation = eqrel;
            eqrel.InitializeRelation();

            Polygons.Add(p1);
            Polygons.Add(p2);
            Circles.Add(c1);
            Circles.Add(c2);
        }
    }
}
