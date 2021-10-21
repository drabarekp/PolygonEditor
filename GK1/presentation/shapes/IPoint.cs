using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public interface IPoint
    {
        public (int X, int Y) Position { get; }
    }
}
