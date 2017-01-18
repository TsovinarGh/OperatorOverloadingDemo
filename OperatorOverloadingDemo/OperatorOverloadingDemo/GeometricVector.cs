using System;


namespace OperatorOverloading
{
    public class GeometricVector
    {   
        protected Point2D StartPosition { get; set; }
        protected Point2D EndPosition { get; set; }
        private Point2D vectorCoordinate;

        #region Constructor
        
        public GeometricVector(Point2D vectorStart, Point2D vectorEnd)
        {
            this.StartPosition = vectorStart;
            this.EndPosition = vectorEnd;
            this.vectorCoordinate = new Point2D((vectorEnd.X - vectorStart.X), (vectorEnd.Y - vectorStart.Y));
        }

        public GeometricVector(float x1, float y1, float x2, float y2)
        {
            this.StartPosition = new Point2D(x1, y1);
            this.EndPosition = new Point2D(x2, y2);
            this.vectorCoordinate = new Point2D((x2 - x1), (y2 - y1));
        }

        public GeometricVector(Point2D vectorCoordinate)
        {
            this.vectorCoordinate = vectorCoordinate;
        }

        public GeometricVector(float x, float y)
        {
            this.vectorCoordinate = new Point2D(x, y);
        }

        #endregion
        // Functions
        public Point2D GetVectorCordinate()
        {
            return vectorCoordinate;
        }

        public override string ToString()
        {
            return ($"{vectorCoordinate}");
        }

        public double GetVectorLength()
        {
            return Math.Sqrt(Math.Pow((this.vectorCoordinate.X), 2) + Math.Pow((this.vectorCoordinate.Y), 2));
        }
        //
        #region Operator Overloading

        public static GeometricVector operator +(GeometricVector pd1, GeometricVector pd2)
        {
            return new GeometricVector(
            new Point2D((pd1.vectorCoordinate.X + pd2.vectorCoordinate.X), (pd1.vectorCoordinate.Y + pd2.vectorCoordinate.Y)));
        }

        public static GeometricVector operator -(GeometricVector pd1, GeometricVector pd2)
        {
            return new GeometricVector(
            new Point2D((pd1.vectorCoordinate.X - pd2.vectorCoordinate.X), (pd1.vectorCoordinate.Y - pd2.vectorCoordinate.Y)));
        }

        public static bool operator ==(GeometricVector pd1, GeometricVector pd2)
        {
            return pd1.Equals(pd2);
        }

        public static bool operator !=(GeometricVector pd1, GeometricVector pd2)
        {
            return (!pd1.Equals(pd2));
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false; 
            }
            var vec = obj as GeometricVector;
            if (vec == null)
            {
                return false;
            }
            return ((this.vectorCoordinate.X == vec.vectorCoordinate.X) && (this.vectorCoordinate.Y == vec.vectorCoordinate.Y));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
