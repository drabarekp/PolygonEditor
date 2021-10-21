using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class SetCenterRelationAdder : RelationAdder, IPictureActionExecuter
    {
        public SetCenterRelationAdder(Presentation presentation) : base(presentation)
        {
            relation = new SetCenterRelation();
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
            circle = presentation.CircleClose(X, Y);
            if (circle != null)
            {
                ((SetCenterRelation)relation).circle = circle;
                circle.singleCircleRelation = ((SetCenterRelation)relation);
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
