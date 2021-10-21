using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public abstract class EdgeCircleRelation : Relation
    {
        public Edge edge;
        public Circle circle;

        public override bool isReady()
        {
            return edge != null && circle != null;
        }
    }
}
