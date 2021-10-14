using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class Edge : ILine
    {
        public (IPoint p1, IPoint p2) EndsPair { get; set; }

        public Edge(IPoint p1, IPoint p2)
        {
            this.EndsPair = (p1, p2);
        }
    }
}
