using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class Edge
    {
        public (Vertex p1, Vertex p2) EndsPair { get; set; }

        public Edge(Vertex p1, Vertex p2)
        {
            this.EndsPair = (p1, p2);
        }
    }
}
