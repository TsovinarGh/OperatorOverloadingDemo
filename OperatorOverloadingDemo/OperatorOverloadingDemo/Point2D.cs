using System;


namespace OperatorOverloading
{
    public struct Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Point2D (float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return ($"Vector coordinates are: {X}, {Y}");
        }


    }
}
