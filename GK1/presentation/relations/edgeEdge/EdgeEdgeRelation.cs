using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    abstract class EdgeEdgeRelation : Relation
    {
        public (Edge e1, Edge e2) edges;

        public override bool isReady()
        {
            return edges.e1 != null && edges.e2 != null;
        }
        public void AddEdge(Edge edge)
        {
            if(edges.e1 == null)
            {
                edges.e1 = edge;
            }
            else if(edges.e2 == null)
            {
                edges.e2 = edge;
            }
        }
        public Edge GetOtherEdge(Edge edge)
        {
            if (edges.e1 == edge) return edges.e2;
            if (edges.e2 == edge) return edges.e1;
            return null;
        }
    }
}
