using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class Vertex : IPoint, IMovable
    {
        public (int X, int Y) Position { get; private set; }
        public (Edge prev, Edge next) AdjacentEdges { get; set; }

        public Vertex(int X, int Y)
        {
            Position = (X, Y);
        }
        public double Distance(int X, int Y)
        {
            return Math.Sqrt((X - Position.X) * (X - Position.X) + (Y - Position.Y) * (Y - Position.Y));
        }
        public void MoveAVector(int X, int Y, List<Edge> alreadyVisited = null, List<Vertex> alreadyMovedVertices = null)
        {
            MoveTo(Position.X + X, Position.Y + Y, alreadyVisited, alreadyMovedVertices);
        }
        public void MoveTo(int X, int Y, List<Edge> alreadyVisited = null, List<Vertex> alreadyMovedVertices = null)
        {
            var prevPosition = (Position.X, Position.Y);
            if(alreadyVisited == null) alreadyVisited = new List<Edge>();
            if (alreadyMovedVertices == null) alreadyMovedVertices = new List<Vertex>();

            if (!alreadyMovedVertices.Contains(this))
            {
                alreadyMovedVertices.Add(this);
                 Position = (X, Y);
            }
            else return;

            if (AdjacentEdges.prev.relation != null)
                AdjacentEdges.prev.relation.EnforceRelation(this, AdjacentEdges.prev, prevPosition, alreadyVisited, alreadyMovedVertices);
            if (AdjacentEdges.next.relation != null)
                AdjacentEdges.next.relation.EnforceRelation(this, AdjacentEdges.next, prevPosition, alreadyVisited, alreadyMovedVertices);
        }
    }
}
