using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class EdgeMover : IShapeMover
    {
        Edge beingMoved;
        (int X, int Y) referencePoint;
        (int X, int Y) initialPositionOfp1;
        (int X, int Y) initialPositionOfp2;
        public EdgeMover(Edge edge, int X, int Y)
        {
            beingMoved = edge;
            referencePoint = (X, Y);
            initialPositionOfp1 = edge.EndsPair.p1.Position;
            initialPositionOfp2 = edge.EndsPair.p2.Position;
        }

        public void MoveTo(int mousePositionX, int mousePositionY)
        {
            (int X, int Y) vector = (mousePositionX - referencePoint.X, mousePositionY - referencePoint.Y);
            beingMoved.EndsPair.p1.MoveTo(initialPositionOfp1.X + vector.X, initialPositionOfp1.Y + vector.Y);
            beingMoved.EndsPair.p2.MoveTo(initialPositionOfp2.X + vector.X, initialPositionOfp2.Y + vector.Y);
        }
    }
}
