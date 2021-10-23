using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class ParallelRelation : EdgeEdgeRelation
    {
        public ParallelRelation()
        {
            id = numberOfRelations++;
        }
        public override void EnforceRelation(Vertex moved, Edge thisEdge, (int X, int Y) newPosition, List<Edge> alreadyMoved, List<Vertex> alreadyMovedVertices, Circle circleMoved = null)
        {
            if (alreadyMoved.Contains(thisEdge)) return;
            if (alreadyMoved == null) alreadyMoved = new List<Edge>();
            alreadyMoved.Add(thisEdge);

            var otherEdge  = GetOtherEdge(thisEdge);
            (double X, double Y) direction;
            double dotProduct1 = thisEdge.UnitVector12.X * otherEdge.UnitVector12.X + thisEdge.UnitVector12.Y * otherEdge.UnitVector12.Y;
            double dotProduct2 = thisEdge.UnitVector21.X * otherEdge.UnitVector12.X + thisEdge.UnitVector21.Y * otherEdge.UnitVector12.Y;
            if (dotProduct1 > dotProduct2) direction = thisEdge.UnitVector12;
            else direction = thisEdge.UnitVector21;
            otherEdge.EndsPair.p2.MoveTo((int)(otherEdge.EndsPair.p1.Position.X + direction.X * otherEdge.Length), (int)(otherEdge.EndsPair.p1.Position.Y + direction.Y * otherEdge.Length), alreadyMoved, alreadyMovedVertices);
        }
        public void InitializeRelation()
        {
            (double X, double Y) direction;
            var thisEdge = edges.e1;
            var otherEdge = edges.e2;
            double dotProduct1 = thisEdge.UnitVector12.X * otherEdge.UnitVector12.X + thisEdge.UnitVector12.Y * otherEdge.UnitVector12.Y;
            double dotProduct2 = thisEdge.UnitVector21.X * otherEdge.UnitVector12.X + thisEdge.UnitVector21.Y * otherEdge.UnitVector12.Y;
            if (dotProduct1 > dotProduct2) direction = thisEdge.UnitVector12;
            else direction = thisEdge.UnitVector21;

            List<Edge> alreadyMoved = new List<Edge>();
            alreadyMoved.Add(thisEdge);
            alreadyMoved.Add(otherEdge);
            edges.e2.EndsPair.p2.MoveTo((int)(edges.e2.EndsPair.p1.Position.X + direction.X * edges.e2.Length), (int)(edges.e2.EndsPair.p1.Position.Y + direction.Y * edges.e2.Length), alreadyMoved);
        }
        public override string GetName()
        {
            return "PR" + id;
        }
    }
}
