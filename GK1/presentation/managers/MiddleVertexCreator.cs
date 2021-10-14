using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1 
{ 
    class MiddleVertexCreator
    {
        public bool RespondsToClick { get; set; }
        Presentation presentation;

        public MiddleVertexCreator(Presentation p)
        {
            RespondsToClick = false;
            presentation = p;
        }
        public void AddMiddleVertexClicked()
        {
            RespondsToClick = true;
        }
        public void Clicked(int X, int Y)
        {
            var (edge, polygon) = WasEdgeClicked(X, Y);
            if (edge == null) return;

            var vertex = new Vertex((edge.EndsPair.p1.Position.X + edge.EndsPair.p2.Position.X) / 2, (edge.EndsPair.p1.Position.Y + edge.EndsPair.p2.Position.Y) / 2);
            AddVertexToPolygon(polygon, (Vertex)edge.EndsPair.p1, vertex);
            BreakEdge(polygon, edge, vertex);
            RespondsToClick = false;
        }

        private void AddVertexToPolygon(Polygon p, Vertex prev, Vertex toAdd)
        {
            Vertex[] array = new Vertex[p.Vertices.Count + 1];
            int i;

            for(i = 0; i < p.Vertices.Count; i++)
            {
                if (p.Vertices[i] != prev)
                {
                    array[i] = p.Vertices[i];
                }
                else { break; }
            }
            array[i++] = prev;
            array[i++] = toAdd;
            
            for(;i<p.Vertices.Count + 1; i++)
            {
                array[i] = p.Vertices[i - 1];
            }

            p.Vertices = array.ToList();
        }

        private void BreakEdge(Polygon p, Edge toBreak, Vertex breakingPoint)
        {
            int i = 0;
            Edge[] array = new Edge[p.Edges.Count + 1];
            for(; i < p.Edges.Count;i++)
            {
                if(p.Edges[i] != toBreak)
                {
                    array[i] = p.Edges[i];
                }
                else { break; }
            }

            var vPrev = toBreak.EndsPair.p1;
            var vNext = toBreak.EndsPair.p2;
            var e1 = new Edge(vPrev, breakingPoint);
            var e2 = new Edge(breakingPoint, vNext);

            array[i++] = e1;
            array[i++] = e2;

            for (; i < p.Edges.Count + 1; i++)
            {
                array[i] = p.Edges[i - 1];
            }

            p.Edges = array.ToList();
        }

        private (Edge edge, Polygon polygon) WasEdgeClicked(int X, int Y)
        {
            const int close = 5;
            int x0 = X;
            int y0 = Y;

            foreach (var p in presentation.Polygons)
            {
                foreach(var e in p.Edges)
                {
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

                    return (e, p);
                }
            }
            return (null, null);
        }
    }
}
