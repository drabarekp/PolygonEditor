using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class ShapeMover : IPictureActionExecuter
    {
        Presentation presentation;
        public bool RespondsToClick { get; set; }
        public bool RespondsToMouseUp { get; set; }
        public bool RespondsToMouseMove { get; set; }

        IMovable beingMoved;
        IShapeMover mover;

        public void ButtonClicked()
        {
            RespondsToClick = true;
        }
        public void Clicked(int X, int Y)
        {
            Polygon pol;
            Vertex v;
            Circle circle;
            
            (v, pol) = presentation.PolygonClose(X, Y);
            if (pol != null)
            {
                mover = new PolygonMover(pol, pol.Vertices.FindIndex(0, pol.Vertices.Count, (a) => { if (a == v) return true; return false; }));
                beingMoved = pol;
                RespondsToClick = false;
                RespondsToMouseMove = true;
                RespondsToMouseUp = true;
                return;
            }
            circle = presentation.CircleClose(X, Y);
            if(circle != null)
            {
                mover = new CircleMover(circle);
                beingMoved = circle;
                RespondsToClick = false;
                RespondsToMouseMove = true;
                RespondsToMouseUp = true;
                return;
            }

            
        }

        public void MouseMove(int X, int Y)
        {
            mover.MoveTo(X, Y);
        }

        public void MouseUp()
        {
            RespondsToMouseMove = false;
            RespondsToMouseUp = false;
        }
        public ShapeMover(Presentation presentation)
        {
            this.presentation = presentation;
            RespondsToClick = false;
            RespondsToMouseUp = false;
            RespondsToMouseMove = false;
            beingMoved = null;
        }
    }
}
