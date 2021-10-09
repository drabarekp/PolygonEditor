using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GK1
{
    public class PresentationPainter
    {
        public PresentationPainter()
        {

        }
        public void DrawPresentation(Presentation p, Graphics g)
        {
            g.Clear(Color.White);

            foreach(var pol in p.Polygons) DrawPolygon(pol, g);
            foreach(var cir in p.Circles) DrawCircle(cir, g);
        }
        private void DrawPolygon(Polygon p, Graphics g)
        {
            foreach (var ver in p.Vertices) DrawVertex(ver, g);
            foreach (var edge in p.Edges) DrawEdge(edge, g);
        }
        private void DrawCircle(Circle c, Graphics g)
        {
            //implement drawing circle
        }
        private void DrawVertex(Vertex v, Graphics g)
        {
            //implement drawing vertex
        }
        private void DrawEdge(Edge e, Graphics g)
        {
            //implement drawing edge
        }
    }
}
