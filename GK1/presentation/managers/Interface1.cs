using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    interface IPictureActionExecuter
    {
        public bool RespondsToClick { get; }
        public bool RespondsToMouseUp { get; }
        public bool RespondsToMouseMove { get; }
        public void Clicked(int X, int Y);
        public void MouseUp();
        public void MouseMove(int X, int Y);
    }
}
