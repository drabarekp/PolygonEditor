using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class SetCenterRelation : SingleCircleRelation
    {
        public override void EnforceRelation(Vertex moved, Edge thisEdge, (int X, int Y) newPosition, List<Edge> alreadyMoved, List<Vertex> alreadyMovedVertices, Circle circle = null)
        {
        }
    }
}
