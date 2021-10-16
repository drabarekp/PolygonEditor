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
            beingMoved = VertexClicked(X, Y);
            if (beingMoved == null) return;
            isMoving = true;
        }
        public void MouseMove(int X, int Y)
        {
            MoveVertex(X, Y);
        }
        public void MouseUp()
        {
            StopMovingVertex();
        }
        public void MoveVertex(int X, int Y)
        {
            if (isMoving)
                beingMoved.Position = (X, Y);
        }

        public void StopMovingVertex()
        {
            isMoving = false;
            beingMoved = null;
        }
        private Vertex VertexClicked(int X, int Y)
        {
            foreach (var p in presentation.Polygons)
            {
                var v = p.VertexClose(X, Y);
                if (v != null) return v;
            }
            return null;
        }

    }
}
