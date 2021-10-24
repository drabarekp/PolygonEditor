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
        Color circleCentercolor = Color.DarkRed;
        Color pointColor = Color.Blue;
        Color lineColor = Color.Black;
        Color fontColorEdge = Color.Blue;
        Color fontColorCircle = Color.DarkRed;
        int fontSize = 10;
        string fontName = "Arial";
        int sizeOfPoint = 3;

        public PresentationPainter()
        {

        }
        public void DrawPresentation(Presentation p, Graphics g, Bitmap b)
        {
            g.Clear(Color.White);

            foreach(var pol in p.Polygons) DrawPolygon(pol, g, b);
            foreach(var cir in p.Circles) DrawCircle(cir, g);
        }
        private void DrawPolygon(Polygon p, Graphics g, Bitmap b)
        {
            foreach (var ver in p.Vertices)
            {
                DrawVertex(ver, g);
                DrawLine(ver.AdjacentEdges.prev, b);
            }
            
        }
        private void DrawCircle(Circle c, Graphics g)
        {
            const int offsetAdd = 15;
            g.DrawEllipse(new Pen(new SolidBrush(lineColor)), new Rectangle(c.Center.X - c.Radius, c.Center.Y - c.Radius, 2*c.Radius, 2*c.Radius));
            g.FillEllipse(new SolidBrush(circleCentercolor), new Rectangle(c.Center.X - sizeOfPoint, c.Center.Y - sizeOfPoint, 2 * sizeOfPoint, 2 * sizeOfPoint));
            int offset = 5;
            if(c.singleCircleRelation != null)
            {
                DrawRelationLabel(c.singleCircleRelation, g, fontColorCircle, c.Center.X, c.Center.Y + offset);
                offset += offsetAdd;
            }
            foreach(var relation in c.edgeCircleRelations)
            {

                DrawRelationLabel(relation, g, fontColorEdge, c.Center.X, c.Center.Y + offset);
                offset += offsetAdd;
                
            }
        }
        private void DrawVertex(IPoint v, Graphics g)
        {
            try
            {
                g.FillEllipse(new SolidBrush(pointColor), new Rectangle(v.Position.X - sizeOfPoint, v.Position.Y - sizeOfPoint, 2 * sizeOfPoint, 2 * sizeOfPoint));
            }
            catch (OverflowException) { }
        }
        private void DrawLine(Edge e, Bitmap b)
        {
            int x = e.EndsPair.p1.Position.X;
            int y = e.EndsPair.p1.Position.Y;
            int x2 = e.EndsPair.p2.Position.X;
            int y2 = e.EndsPair.p2.Position.Y;

            int w = x2 - x;
            int h = y2 - y;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;
            if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;
            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);
            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);
                if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
                dx2 = 0;
            }
            int numerator = longest >> 1;
            for (int i = 0; i <= longest; i++)
            {
                try
                {
                    b.SetPixel(x, y, Color.Black);
                }
                catch(ArgumentOutOfRangeException)
                {
                    //temporary excption catching here
                }
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }

            if (e.relation != null)
            {
                var g = Graphics.FromImage(b);
                DrawRelationLabel(e.relation, g, fontColorEdge, (e.EndsPair.p1.Position.X + e.EndsPair.p2.Position.X) / 2, (e.EndsPair.p1.Position.Y + e.EndsPair.p2.Position.Y) / 2);
            }
        }
        private void DrawRelationLabel(Relation relation, Graphics graphics, Color fontColor,  int X, int Y)
        {
            graphics.DrawString(relation.GetName(), new Font(fontName, fontSize, FontStyle.Bold), new SolidBrush(fontColor),new PointF(X, Y));
        }
    }
}
