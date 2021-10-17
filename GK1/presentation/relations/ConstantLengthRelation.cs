using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class ConstantLengthRelation : SingleEdgeRelation
    {
        public ConstantLengthRelation(Edge edge)
        {
            this.edgeInRelation = edge;
        }
        public override void EnforceRelation(Vertex moved, (int X, int Y) newPosition)
        {
            edgeInRelation.MoveAVector(newPosition.X - moved.Position.X, newPosition.Y - moved.Position.Y);
        }
    }
}
