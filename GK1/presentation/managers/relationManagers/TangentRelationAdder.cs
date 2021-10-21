using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class TangentRelationAdder : RelationAdder, IPictureActionExecuter
    {
        public TangentRelationAdder(Presentation presentation) : base(presentation)
        {
            relation = new TangentRelation();
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
            Circle circle;
            Edge edge;

            circle = presentation.CircleClose(X, Y);
            (edge, _) = presentation.EdgeClose(X, Y);
            if(circle != null)
            {
                ((TangentRelation)relation).circle = circle;
            }
            else if(edge != null)
            {
                ((TangentRelation)relation).edge = edge;
            }

            if (relation.isReady())
            {
                ((TangentRelation)relation).circle.edgeCircleRelations.Add(((TangentRelation)relation));
                ((TangentRelation)relation).edge.relation = relation;
                ((TangentRelation)relation).InitializeRelation();
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
