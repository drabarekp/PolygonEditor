using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class PresentationManager
    {
        private Presentation presentation;
        private CircleAdder circleAdder;
        private PolygonAdder polygonAdder;
        private PolygonModifier polygonModifier;
        private MiddleVertexCreator middleVertexCreator;

        public PresentationManager(Presentation presentation)
        {
            this.presentation = presentation;
            circleAdder = new CircleAdder(presentation);
            polygonAdder = new PolygonAdder(presentation);
            polygonModifier = new PolygonModifier(presentation);
            middleVertexCreator = new MiddleVertexCreator(presentation);
 
        }

        // in reality down
        public void Clicked(int X, int Y)
        {
            if (polygonAdder.RespondsToClick)
            {
                polygonAdder.Clicked(X, Y);
            }
            if (circleAdder.RespondsToClick)
            {
                circleAdder.Clicked(X, Y);
            }
            if (polygonModifier.RespondsToClick)
            {
                polygonModifier.Clicked(X, Y);
            }
            if (middleVertexCreator.RespondsToClick)
            {
                middleVertexCreator.Clicked(X, Y);
            }
        }
        
        public void MouseMove(int X, int Y)
        {
            if(polygonModifier.RespondsToMouseMove)
                polygonModifier.MouseMove(X, Y);
            if (circleAdder.RespondsToMouseMove)
                circleAdder.MouseMove(X, Y);
        }
        public void MouseUp()
        {
            polygonModifier.MouseUp();
        }

        public void AddPolygonButtonClicked()
        {
            polygonAdder.AddPolygonButtonClicked();
        }
        public void AddCircleButtonClicked()
        {
            circleAdder.AddCircleButtonClicked();
        }
        public void AddMiddleVertexPointClicked()
        {
            middleVertexCreator.AddMiddleVertexClicked();
        }
    }
}
