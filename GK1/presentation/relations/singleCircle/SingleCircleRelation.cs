using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public abstract class SingleCircleRelation : Relation
    {
        public Circle circle;

        public override bool isReady()
        {
            return circle != null;
        }
        public override void DisposeSelf()
        {
            circle.singleCircleRelation = null;
        }
    }
}
