using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class PolygonAdder : IPictureActionExecuter
    {
        bool isAdding;
        Polygon beingAdded;
        Presentation presentation;
        public bool RespondsToClick
        {
            get
            {
                return isAdding;
            }
        }

        public bool RespondsToMouseUp { get => false; }

        public bool RespondsToMouseMove { get => false; }

        public PolygonAdder(Presentation p)
        {
            presentation = p;
            isAdding = false;
            beingAdded = null;
        }

        public void Clicked(int X, int Y)
        {
            AddVertexToPolygon(X, Y);
        }
        public void MouseUp()
        {
            throw new NotImplementedException();
        }

        public void MouseMove(int X, int Y)
        {
            throw new NotImplementedException();
        }

        public void ButtonClicked()
        {
            if (isAdding)
            {
                StopAddingPolygon();
                return;
            }

            AddPolygon();
        }
        private void AddPolygon()
        {
            beingAdded = new Polygon();
            presentation.Polygons.Add(beingAdded);
            isAdding = true;
        }

        private void StopAddingPolygon()
        {
            isAdding = false;
            beingAdded = null;
        }
        private void AddVertexToPolygon(int X, int Y)
        {
            beingAdded.AddVertex(new Vertex(X, Y));
        }
    }
}
