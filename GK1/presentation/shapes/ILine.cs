using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    interface ILine
    {
        public (IPoint p1, IPoint p2) EndsPair { get; set; }
    }
}
