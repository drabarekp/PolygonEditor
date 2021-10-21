using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class RelationAdder
    {
        protected Relation relation;
        protected Presentation presentation;

        public RelationAdder(Presentation presentation)
        {
            this.presentation = presentation;
        }
    }
}
