using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class EqualLengthsRelation : EdgeEdgeRelation
    {
        public EqualLengthsRelation()
        {
            id = numberOfRelations++;
        }
        public void InitializeRelation()
        {
            var p1 = edges.e2.EndsPair.p1;
            var p2 = edges.e2.EndsPair.p2;
            p2.MoveTo((int)(p1.Position.X + edges.e2.UnitVector12.X * edges.e1.Length), (int)(p1.Position.Y + edges.e2.UnitVector12.Y * edges.e1.Length));
        }
        public override void EnforceRelation(Vertex moved, Edge thisEdge, (int X, int Y) oldPosition, List<Edge> alreadyMoved, List<Vertex> alreadyMovedVertices, Circle circle = null)
        {
            if (alreadyMoved.Contains(thisEdge)) return;
            alreadyMoved.Add(thisEdge);

            var otherEdgeInRelation = GetOtherEdge(thisEdge);
            var p1 = otherEdgeInRelation.EndsPair.p1;
            var p2 = otherEdgeInRelation.EndsPair.p2;

            p2.MoveTo((int)(p1.Position.X + otherEdgeInRelation.UnitVector12.X * thisEdge.Length), (int)(p1.Position.Y + otherEdgeInRelation.UnitVector12.Y * thisEdge.Length), alreadyMoved, alreadyMovedVertices);
            
        }
        public override string GetName()
        {
            return "EL" + id;
        }
    }
}
