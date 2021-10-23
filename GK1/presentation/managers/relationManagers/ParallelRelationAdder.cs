using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class ParallelRelationAdder : RelationAdder, IPictureActionExecuter
    {
        public ParallelRelationAdder(Presentation presentation) : base(presentation)
        {
            relation = new ParallelRelation();
        }

        public bool RespondsToClick {get; set;} = true;

        public bool RespondsToMouseUp => false;

        public bool RespondsToMouseMove => false;

        public void ButtonClicked()
        {

        }

        public void Clicked(int X, int Y)
        {
            Edge edge;
            (edge, _) = presentation.EdgeClose(X, Y);
            if (edge != null)
            {
                ((ParallelRelation)relation).AddEdge(edge);
            }
            if (relation.isReady())
            {
                ((ParallelRelation)relation).edges.e1.relation = relation;
                ((ParallelRelation)relation).edges.e2.relation = relation;
                ((ParallelRelation)relation).InitializeRelation();
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
