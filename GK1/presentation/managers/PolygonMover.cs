using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class PolygonMover : IShapeMover
    {
        int referenceVertexIndex;
        Polygon beingMoved;

        public PolygonMover(Polygon polygon, int referenceVertexIndex)
        {
            this.beingMoved = polygon;
            this.referenceVertexIndex = referenceVertexIndex;
        }
        public void MoveTo(int mousePositionX, int mousePositionY)
        {
            var currentPosition = beingMoved.Vertices[referenceVertexIndex].Position;
            (int X, int Y) vector = (mousePositionX - currentPosition.X, mousePositionY - currentPosition.Y);
            beingMoved.MoveAVector(vector.X, vector.Y);
        }
    }
}
