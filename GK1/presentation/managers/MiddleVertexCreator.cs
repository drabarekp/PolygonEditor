using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1 
{ 
    class MiddleVertexCreator : IPictureActionExecuter
    {
        public bool RespondsToClick { get; set; }

        public bool RespondsToMouseUp {get => false;} 

        public bool RespondsToMouseMove { get => false; }

        Presentation presentation;

        public MiddleVertexCreator(Presentation p)
        {
            RespondsToClick = false;
            presentation = p;
        }
        public void ButtonClicked()
        {
            RespondsToClick = true;
        }
        public void Clicked(int X, int Y)
        {
            var (edge, polygon) = WasEdgeClicked(X, Y);
            if (edge == null) return;

            var vertex = new Vertex((edge.EndsPair.p1.Position.X + edge.EndsPair.p2.Position.X) / 2, (edge.EndsPair.p1.Position.Y + edge.EndsPair.p2.Position.Y) / 2);
            AddVertexToPolygon(polygon, (Vertex)edge.EndsPair.p1, vertex);
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

            Vertex next = prev.AdjacentEdges.next.EndsPair.p2;
            var ePrev = new Edge(prev, toAdd);
            var eNext = new Edge(toAdd, next);

            prev.AdjacentEdges = (prev.AdjacentEdges.prev, ePrev);
            toAdd.AdjacentEdges = (ePrev, eNext);
            next.AdjacentEdges = (eNext, next.AdjacentEdges.next);
            p.Vertices = array.ToList();
        }

        private (Edge edge, Polygon polygon) WasEdgeClicked(int X, int Y)
        {
            const int close = 5;
            int x0 = X;
            int y0 = Y;

            foreach (var p in presentation.Polygons)
            {
                foreach(var v in p.Vertices)
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

                    return (e, p);
                }
            }
            return (null, null);
        }

        public void MouseUp()
        {
            throw new NotImplementedException();
        }

        public void MouseMove(int X, int Y)
        {
            throw new NotImplementedException();
        }
    }
}
