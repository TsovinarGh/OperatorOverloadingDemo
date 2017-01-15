using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo
{
    public struct Point2D
    {
        public byte X { get; set; }
        public byte Y { get; set; }
        public Point2D (byte x, byte y)
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
