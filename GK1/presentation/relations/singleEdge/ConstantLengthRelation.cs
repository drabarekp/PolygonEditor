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
            id = numberOfRelations++;
        }
        public ConstantLengthRelation(Edge edge)
        {
            this.edgeInRelation = edge;
        }
        public override void EnforceRelation(Vertex moved, Edge thisEdge, (int X, int Y) oldPosition, List<Edge> alreadyMoved, List<Vertex> alreadyMovedVertices, Circle circle = null)
        {
            if (alreadyMoved.Contains(thisEdge)) return;
            alreadyMoved.Add(thisEdge);

            double initialLength = thisEdge.GetAnotherEnd(moved).Distance(oldPosition.X, oldPosition.Y);
            (double X, double Y) unitvector = ((thisEdge.GetAnotherEnd(moved).Position.X - moved.Position.X)/thisEdge.Length, (thisEdge.GetAnotherEnd(moved).Position.Y - moved.Position.Y)/ thisEdge.Length);
            
            // 0.5 is added to coordinates to eliminate rounding errors
            thisEdge.GetAnotherEnd(moved).MoveTo((int)(moved.Position.X + (unitvector.X * initialLength) + 0.5), (int)(moved.Position.Y + (unitvector.Y * initialLength) + 0.5), alreadyMoved, alreadyMovedVertices);
        }
        public override string GetName()
        {
            return "CL" + id;
        }
    }
}
