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
        private VertexRemover vertexRemover;
        private RadiusChanger radiusChanger;
        private ShapeMover shapeMover;

        private List<IPictureActionExecuter> listeners;

        public PresentationManager(Presentation presentation)
        {
            this.presentation = presentation;
            circleAdder = new CircleAdder(presentation);
            polygonAdder = new PolygonAdder(presentation);
            polygonModifier = new PolygonModifier(presentation);
            middleVertexCreator = new MiddleVertexCreator(presentation);
            vertexRemover = new VertexRemover(presentation);
            radiusChanger = new RadiusChanger(presentation);
            shapeMover = new ShapeMover(presentation);
            
            listeners = new List<IPictureActionExecuter>();
            listeners.Add(shapeMover);
            listeners.Add(circleAdder);
            listeners.Add(polygonAdder);
            listeners.Add(polygonModifier);
            listeners.Add(middleVertexCreator);
            listeners.Add(vertexRemover);
            listeners.Add(radiusChanger);
            

        }

        // in reality down
        public void Clicked(int X, int Y)
        {
            foreach(var listener in listeners)
            {
                if (listener.RespondsToClick)
                {
                    listener.Clicked(X, Y);
                }
            }
        }
        
        public void MouseMove(int X, int Y)
        {
            foreach (var listener in listeners)
            {
                if (listener.RespondsToMouseMove)
                {
                    listener.MouseMove(X, Y);
                }
            }
        }
        public void MouseUp()
        {
            foreach (var listener in listeners)
            {
                if (listener.RespondsToMouseUp)
                {
                    listener.MouseUp();
                }
            }
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
        public void RemoveVertexButtonClicked()
        {
            vertexRemover.ButtonClicked();
        }
        public void ChangeRadiusClicked()
        {
            radiusChanger.ButtonClicked();
        }
        public void MoveShapeButtonClicked()
        {
            shapeMover.ButtonClicked();
        }
    }
}
