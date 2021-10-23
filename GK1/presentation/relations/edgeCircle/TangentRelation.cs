using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    class TangentRelation : EdgeCircleRelation
    {
        public TangentRelation()
        {
            id = numberOfRelations++;
        }
        public void InitializeRelation(List<Edge> alreadyVisited = null, List<Vertex> alreadyMovedVertices = null)
        {
            double distanceCircleToLine = edge.DistanceToPoint(circle.Center);
            if (alreadyVisited == null) alreadyVisited = new List<Edge>();
            //if radius can't be changed:
            /*if (circle.singleCircleRelation is ConstantRadiusRelation)
            {*/
                int epsilon = 2;
                
                double lengthToMoveCircle = circle.Radius - distanceCircleToLine;

                (int X, int Y) possibleNewPosition1 = (circle.Center.X + (int)(edge.UnitVectorPerpendicular.X * lengthToMoveCircle),
                    circle.Center.Y + (int)(edge.UnitVectorPerpendicular.Y * lengthToMoveCircle));
                (int X, int Y) possibleNewPosition2 = (circle.Center.X - (int)(edge.UnitVectorPerpendicular.X * lengthToMoveCircle),
                    circle.Center.Y - (int)(edge.UnitVectorPerpendicular.Y * lengthToMoveCircle));
                var tmp1 = edge.DistanceToPoint(possibleNewPosition1);
                var tmp2 = edge.DistanceToPoint(possibleNewPosition2);

                alreadyVisited.Add(edge);

                if (edge.DistanceToPoint(possibleNewPosition1) - circle.Radius < epsilon)
                {
                    //circle.MoveTo(possibleNewPosition1.X, possibleNewPosition1.Y, alreadyVisited, alreadyMovedVertices);
                    edge.MoveAVector(-(int)(edge.UnitVectorPerpendicular.X * lengthToMoveCircle), -(int)(edge.UnitVectorPerpendicular.Y * lengthToMoveCircle), alreadyVisited);
                }
                else if (edge.DistanceToPoint(possibleNewPosition2) - circle.Radius < epsilon)
                {
                    //circle.MoveTo(possibleNewPosition2.X, possibleNewPosition2.Y, alreadyVisited, alreadyMovedVertices);
                    edge.MoveAVector((int)(edge.UnitVectorPerpendicular.X * lengthToMoveCircle), (int)(edge.UnitVectorPerpendicular.Y * lengthToMoveCircle), alreadyVisited);
                }
            //}
            //if radius can be changed
            /*else
            {
                circle.SetRadius((int)distanceCircleToLine, alreadyVisited);
            }*/
        }
        public override void EnforceRelation(Vertex moved, Edge thisEdge, (int X, int Y) newPosition, List<Edge> alreadyMoved, List<Vertex> alreadyMovedVertices, Circle circle = null)
        {
            if (alreadyMoved.Contains(edge)) return;
            alreadyMoved.Add(edge);

            InitializeRelation(alreadyMoved, alreadyMovedVertices);
        }
        public override string GetName()
        {
            return "T" + id;
        }
    }
}
