using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class CircleMover : IShapeMover
    {
        Circle beingMoved;

        public CircleMover(Circle circle)
        {
            beingMoved = circle;
        }
        public void MoveTo(int mousePositionX, int mousePositionY)
        {
            beingMoved.Center = (mousePositionX, mousePositionY);
        }
    }
}
