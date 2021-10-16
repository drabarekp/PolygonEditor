using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class CircleAdder :IPictureActionExecuter
    {
        private bool isAddingCircle;
        private bool wasCenterSet;
        Circle beingAdded;
        Presentation presentation;

        public bool RespondsToClick
        {
            get
            {
                return isAddingCircle;
            }
        }
        public bool RespondsToMouseMove
        {
            get
            {
                return isAddingCircle && wasCenterSet;
            }
        }
        public void MouseUp()
        {
            throw new NotImplementedException();
        }

        public bool RespondsToMouseUp { get => false; }

        public CircleAdder(Presentation pres)
        {
            this.presentation = pres;
            isAddingCircle = false;
            wasCenterSet = false;
        }

        public void Clicked(int X, int Y)
        {
            if (isAddingCircle && wasCenterSet) StopAddingCircle();
            else if (isAddingCircle)
            {
                SetCenter(X, Y);
            }
        }
        public void MouseMove(int X, int Y)
        {
            SetRadius(X, Y);
        }
        public void AddCircleButtonClicked()
        {
            AddCircle();
        }
        private void AddCircle()
        {
            beingAdded = new Circle();
            presentation.Circles.Add(beingAdded);
            isAddingCircle = true;
            wasCenterSet = false;
        }
        private void SetCenter(int X, int Y)
        {
            beingAdded.Center = (X, Y);
            wasCenterSet = true;
        }
        private void SetRadius(int X, int Y)
        {
            beingAdded.Radius = (int)beingAdded.DistanceFromCenter(X, Y);
            
        }
        private void StopAddingCircle()
        {
            isAddingCircle = false;
            wasCenterSet = false;
            beingAdded = null;
        }

    }
}
