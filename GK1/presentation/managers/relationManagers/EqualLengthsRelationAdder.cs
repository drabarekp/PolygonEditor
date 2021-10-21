using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class EqualLengthsRelationAdder : RelationAdder, IPictureActionExecuter
    {
        public EqualLengthsRelationAdder(Presentation presentation) : base(presentation)
        {
            relation = new EqualLengthsRelation();
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
            Edge edge;
            (edge, _) = presentation.EdgeClose(X, Y);
            if(edge != null)
            {
                ((EqualLengthsRelation)relation).AddEdge(edge);
            }
            if (relation.isReady())
            {
                RespondsToClick = false;
                ((EqualLengthsRelation)relation).edges.e1.relation = relation;
                ((EqualLengthsRelation)relation).edges.e2.relation = relation;
                ((EqualLengthsRelation)relation).InitializeRelation();
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
