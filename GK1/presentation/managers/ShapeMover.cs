using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class ShapeMover : IPictureActionExecuter
    {
        public bool RespondsToClick { get; set; }

        public bool RespondsToMouseUp => false;

        public bool RespondsToMouseMove { get; set; }

        public void Clicked(int X, int Y)
        {
            throw new NotImplementedException();
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
