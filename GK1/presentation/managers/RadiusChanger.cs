using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class RadiusChanger : IPictureActionExecuter
    {
        Presentation presentation;
        public bool RespondsToClick { get; set; }

        public bool RespondsToMouseUp => false;

        public bool RespondsToMouseMove { get; set; }
        
        private Circle beingChanged;

        private bool changingRadius = false;


        public RadiusChanger(Presentation p)
        {
            presentation = p;
            RespondsToClick = false;
            RespondsToMouseMove = false;
            beingChanged = null;
        }

        public void Clicked(int X, int Y)
        {
            if (changingRadius)
            {
                SetRadius();
                return;
            }

            int close = 5;
            foreach(var circle in presentation.Circles)
            {
                if(circle.DistanceFromCenter(X, Y) < close)
                {
                    beingChanged = circle;
                    RespondsToMouseMove = true;
                    changingRadius = true;
                    break;
                }
            }
        }

        private void SetRadius()
        {
            RespondsToClick = false;
            RespondsToMouseMove = false;
            changingRadius = false;
        }

        public void ButtonClicked()
        {
            RespondsToClick = true;
        }

        public void MouseMove(int X, int Y)
        {
            beingChanged.Radius = (int)beingChanged.DistanceFromCenter(X, Y);
        }

        public void MouseUp()
        {
            throw new NotImplementedException();
        }
    }
}
