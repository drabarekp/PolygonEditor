using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class PolygonModifier : IPictureActionExecuter
    {
        Vertex beingMoved;
        EdgeMover edgeMover;
        bool isMoving;
        Presentation presentation;
        public bool RespondsToClick
        {
            get
            {
                return true;
            }
        }
        public bool RespondsToMouseUp {
            get
            {
                return isMoving;
            }
        }
        public bool RespondsToMouseMove
        {
            get
            {
                return isMoving;
            }
        }

        public PolygonModifier(Presentation presentation)
        {
            this.presentation = presentation;
            isMoving = false;
            beingMoved = null;
        }
        public void Clicked(int X, int Y)
        {
            (beingMoved, _) = presentation.PolygonClose(X, Y);
            if (beingMoved != null)
            {
                isMoving = true;
                return;
            }

            foreach (var p in presentation.Polygons)
            {
                var (edge, polygon) = p.WasEdgeClose(X, Y);
                if (edge != null)
                {
                    edgeMover = new EdgeMover(edge, X, Y);
                    isMoving = true;
                    return;
                }
            }
        }
        public void MouseMove(int X, int Y)
        {
            if(beingMoved != null)
                MoveVertex(X, Y);
            else
            {
                edgeMover.MoveTo(X, Y);
            }
        }
        public void MouseUp()
        {
            StopMovingVertex();
        }
        public void MoveVertex(int X, int Y)
        {
            if (isMoving)
                beingMoved.MoveTo(X, Y);
        }

        public void StopMovingVertex()
        {
            isMoving = false;
            beingMoved = null;
            edgeMover = null;
        }

        public void ButtonClicked()
        {
            throw new NotImplementedException();
        }
    }
}
