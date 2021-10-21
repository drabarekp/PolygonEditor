using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class ConstantLengthRelation : SingleEdgeRelation
    {
        public ConstantLengthRelation()
        {

        }
        public ConstantLengthRelation(Edge edge)
        {
            this.edgeInRelation = edge;
        }
        public override void EnforceRelation(Vertex moved, Edge thisEdge, (int X, int Y) oldPosition, List<Edge> alreadyMoved, List<Vertex> alreadyMovedVertices, Circle circle = null)
        {
            if (alreadyMoved.Contains(thisEdge)) return;
            alreadyMoved.Add(thisEdge);

            (int X, int Y) vector = (moved.Position.X - oldPosition.X, moved.Position.Y - oldPosition.Y);

            
            thisEdge.GetAnotherEnd(moved).MoveAVector(vector.X, vector.Y, alreadyMoved, alreadyMovedVertices);
           
        }
    }
}
