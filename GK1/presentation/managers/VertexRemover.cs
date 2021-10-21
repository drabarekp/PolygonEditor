using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class VertexRemover : IPictureActionExecuter
    {
        Presentation presentation;
        public bool RespondsToClick { get; set; }

        public bool RespondsToMouseUp => false;

        public bool RespondsToMouseMove => false;

        public void Clicked(int X, int Y)
        {
            var (vertex, polygon)  = presentation.PolygonClose(X, Y);
            if (vertex == null) return;
            RemoveVertex(vertex, polygon);
            RespondsToClick = false;
        }

        public void MouseMove(int X, int Y)
        {
            throw new NotImplementedException();
        }

        public void MouseUp()
        {
            throw new NotImplementedException();
        }
        public VertexRemover(Presentation p)
        {
            presentation = p;
            RespondsToClick = true;
        }
        public void ButtonClicked()
        {

        }

        private void RemoveVertex(Vertex v, Polygon p)
        {
            int indexOfRemoved = p.Vertices.FindIndex(0, p.Vertices.Count, (arg) => { if (arg == v) return true; return false; });
            int indexOfNext = (indexOfRemoved + 1) % p.Vertices.Count;
            int indexOfPrev = (indexOfRemoved - 1 + p.Vertices.Count) % p.Vertices.Count;

            var prev = p.Vertices[indexOfPrev];
            var next = p.Vertices[indexOfNext];
            var e = new Edge(prev, next);

            prev.AdjacentEdges = (prev.AdjacentEdges.prev, e);
            next.AdjacentEdges = (e, next.AdjacentEdges.next);
            p.Vertices.Remove(v);

        }
    }
}
