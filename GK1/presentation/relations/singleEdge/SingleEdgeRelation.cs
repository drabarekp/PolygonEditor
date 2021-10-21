using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public abstract class SingleEdgeRelation : Relation
    {
        public Edge edgeInRelation;

        public void AddEdge(Edge edge)
        {
            edgeInRelation = edge;
        }
        public override bool isReady()
        {
            return edgeInRelation != null;
        }
    }
}
