using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class RelationRemover : RelationAdder, IPictureActionExecuter
    {
        public RelationRemover(Presentation presentation) : base(presentation)
        {
            this.presentation = presentation;
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
                edge.relation.DisposeSelf();
                return;
            }
            var circle = presentation.CircleClose(X, Y);
            if(circle != null)
            {
                circle.singleCircleRelation.DisposeSelf();
                return;
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
