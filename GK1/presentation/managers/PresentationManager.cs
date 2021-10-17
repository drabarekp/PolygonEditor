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

        private IPictureActionExecuter activeManager;
        private PolygonModifier polygonModifier;
        public PresentationManager(Presentation presentation)
        {
            this.presentation = presentation;
            polygonModifier = new PolygonModifier(presentation);
            activeManager = null;
        }

        // in reality down
        public void Clicked(int X, int Y)
        {
            if(activeManager == null || !activeManager.RespondsToClick)
            {
                if (polygonModifier.RespondsToClick)
                    polygonModifier.Clicked(X, Y);
            }
            else
            {
                if (activeManager.RespondsToClick)
                    activeManager.Clicked(X, Y);
            }
        }
        
        public void MouseMove(int X, int Y)
        {
            if (activeManager == null || !activeManager.RespondsToMouseMove)
            {
                if (polygonModifier.RespondsToMouseMove)
                    polygonModifier.MouseMove(X, Y);
            }
            else
            {
                if (activeManager.RespondsToMouseMove)
                    activeManager.MouseMove(X, Y);
            }

        }
        public void MouseUp()
        {
            if (activeManager == null || !activeManager.RespondsToMouseUp)
                {
                    if (polygonModifier.RespondsToMouseUp)
                        polygonModifier.MouseUp();
                }
            else
            {
                if (activeManager.RespondsToMouseUp)
                    activeManager.MouseUp();
            }
        }

        public void AddPolygonButtonClicked()
        {
            activeManager = new PolygonAdder(presentation);
            activeManager.ButtonClicked();
            
        }
        public void AddCircleButtonClicked()
        {
            activeManager = new CircleAdder(presentation);
            activeManager.ButtonClicked();
        }
        public void AddMiddleVertexPointClicked()
        {
            activeManager = new MiddleVertexCreator(presentation);
            activeManager.ButtonClicked();
        }
        public void RemoveVertexButtonClicked()
        {
            activeManager = new VertexRemover(presentation);
            activeManager.ButtonClicked();
        }
        public void ChangeRadiusClicked()
        {
            activeManager = new RadiusChanger(presentation);
            activeManager.ButtonClicked();
        }
        public void MoveShapeButtonClicked()
        {
            activeManager = new ShapeMover(presentation);
            activeManager.ButtonClicked();
        }
        public void EndSpecialAction()
        {
            activeManager = null;
        }
    }
}
