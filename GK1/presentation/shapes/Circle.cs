using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class Circle : IMovable
    {
        public (int X, int Y) Center { get; private set; }
        public int Radius { get; private set; }
        public SingleCircleRelation singleCircleRelation;
        public List<EdgeCircleRelation> edgeCircleRelations = new List<EdgeCircleRelation>();
        public Circle() { }
        public Circle((int X, int Y) center, int rad)
        {
            Center = center;
            Radius = rad;
        }
        public double DistanceFromCenter(int X, int Y)
        {
            return Math.Sqrt((Center.X - X) * (Center.X - X) + (Center.Y - Y) * (Center.Y - Y));
        }

        public void MoveAVector(int X, int Y, List<Edge> alreadyVisited = null, List<Vertex> alreadyMovedVertices = null)
        {
            MoveTo(Center.X + X, Center.Y + Y, alreadyVisited);
        }
        public void MoveTo(int X, int Y, List<Edge> alreadyVisited = null, List<Vertex> alreadyVisitedVertices = null)
        {
            if (singleCircleRelation is SetCenterRelation) return;
            Center = (X, Y);
            if(alreadyVisited == null) alreadyVisited = new List<Edge>();
            foreach (var r in edgeCircleRelations)
            {
                r.EnforceRelation(null, null, (0, 0), alreadyVisited, alreadyVisitedVertices, circleMoved: this);
            }
        }
        public void SetRadius(int newRadius, List<Edge> alreadyVisited = null, List<Vertex> alreadyVisitedVertices = null)
        {
            if (singleCircleRelation is ConstantRadiusRelation) return;
            Radius = newRadius;
            if (alreadyVisited == null) alreadyVisited = new List<Edge>();
            foreach (var r in edgeCircleRelations)
            {
                r.EnforceRelation(null, null, (0, 0), alreadyVisited, alreadyVisitedVertices, circleMoved: this);
            }
        }
    }
}
