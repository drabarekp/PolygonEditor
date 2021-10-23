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
        }
        public void AddCircleButtonClicked()
        {
            activeManager = new CircleAdder(presentation);
        }
        public void AddMiddleVertexPointClicked()
        {
            activeManager = new MiddleVertexCreator(presentation);
        }
        public void RemoveVertexButtonClicked()
        {
            activeManager = new VertexRemover(presentation);
        }
        public void ChangeRadiusClicked()
        {
            activeManager = new RadiusChanger(presentation);
        }
        public void MoveShapeButtonClicked()
        {
            activeManager = new ShapeMover(presentation);
        }
        public void EndSpecialAction()
        {
            activeManager = new PolygonModifier(presentation);
        }

        public void SetEdgeLegthClicked()
        {
            activeManager = new ConstantLengthRelationAdder(presentation);
        }
        public void SetCircleRadiusClicked()
        {
            activeManager = new ConstantRadiusRelationAdder(presentation);
        }
        public void SetEqalsLengthsClicked()
        {
            activeManager = new EqualLengthsRelationAdder(presentation);
        }
        public void TangencyRelationClicked()
        {
            activeManager = new TangentRelationAdder(presentation);
        }
        public void SetCircleCenterClicked()
        {
            activeManager = new SetCenterRelationAdder(presentation);
        }
        public void ParallelRelationClicked()
        {
            activeManager = new ParallelRelationAdder(presentation);
        }
        public void RemoveRelationClicked()
        {
            activeManager = new RelationRemover(presentation);
        }
    }
}
