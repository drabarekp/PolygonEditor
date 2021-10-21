using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class ConstantRadiusRelationAdder : RelationAdder, IPictureActionExecuter
    {
        public ConstantRadiusRelationAdder(Presentation presentation) : base(presentation)
        {
            relation = new ConstantRadiusRelation();
        }

        public bool RespondsToClick {get; set;} = true;

        public bool RespondsToMouseUp => false;

        public bool RespondsToMouseMove => false;

        public void ButtonClicked()
        {
            throw new NotImplementedException();
        }

        public void Clicked(int X, int Y)
        {
            var circle = presentation.CircleClose(X, Y);
            if(circle != null)
            {
                ((ConstantRadiusRelation)relation).circle = circle;
                circle.singleCircleRelation = ((ConstantRadiusRelation)relation);
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
