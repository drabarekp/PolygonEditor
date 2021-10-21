using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class ConstantLengthRelationAdder : RelationAdder, IPictureActionExecuter
    {
        public ConstantLengthRelationAdder(Presentation presentation) :base(presentation)
        {
            relation = new ConstantLengthRelation();
        }

        public bool RespondsToClick { get; set; } = true;

        public bool RespondsToMouseUp => false;

        public bool RespondsToMouseMove => false;

        public void ButtonClicked()
        {
            throw new NotImplementedException();
        }

        public void Clicked(int X, int Y)
        {
            Edge e =null;
            (e, _) = presentation.EdgeClose(X, Y);
            if (e != null)
            {
                ((ConstantLengthRelation)relation).edgeInRelation = e;
                e.relation = relation;
                RespondsToClick = false;
            }
        }

        public void MouseMove(int X, int Y)
        {
            throw new NotImplementedException();
        }

        public void MouseUp()
        {
            throw new NotImplementedException();
        }
    }
}
