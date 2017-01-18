using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo
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
            return ($" Vector coordinates are {X},{Y}");
        }


    }
}
