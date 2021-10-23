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
            thisEdge.GetAnotherEnd(moved).MoveTo(moved.Position.X + (int)(unitvector.X * initialLength), moved.Position.Y + (int)(unitvector.Y * initialLength));

            /*(int X, int Y) vector = (moved.Position.X - oldPosition.X, moved.Position.Y - oldPosition.Y);
            thisEdge.GetAnotherEnd(moved).MoveAVector(vector.X, vector.Y, alreadyMoved, alreadyMovedVertices);*/

        }
        public override string GetName()
        {
            return "CL" + id;
        }
    }
}
