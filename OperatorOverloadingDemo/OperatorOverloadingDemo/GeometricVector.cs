using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingDemo
{
    //Երկու վեկտորների տարբերության յուրաքանչյուր կոորդինատ հավասար է 
    //այդ վեկտորների համապատասխան կոորդինատների տարբերությանը։

    public class GeometricVector
    {
        protected Point2D StartPosition { get; set; }
        protected Point2D EndPosition { get; set; }
        private Point2D coordinate;
      //  protected 

        public GeometricVector(Point2D start, Point2D end)
        {
            this.StartPosition = start;
            this.EndPosition = end;
            this.coordinate = new Point2D((byte)(end.X - start.X), (byte)(end.Y - start.Y));
        }

        public GeometricVector(byte x1, byte y1, byte x2, byte y2)
        {
            this.StartPosition = new Point2D(x1, y1);
            this.EndPosition = new Point2D(x2, y2);
        }

        private GeometricVector(Point2D coordinate)
        {
            this.coordinate = coordinate;
        }

        public override string ToString()
        {
            return ($"Vectors start coordinats are {StartPosition}, Vectors end coordinats are {EndPosition}");
        }

        public static GeometricVector operator + (GeometricVector pd1, GeometricVector pd2)
        {
            return new GeometricVector( new Point2D((byte)(pd1.coordinate.X+pd2.coordinate.X), (byte)(pd1.coordinate.Y+pd2.coordinate.Y)));
        }

        public static GeometricVector operator -(GeometricVector pd1, GeometricVector pd2)
        {
            return new GeometricVector(new Point2D((byte)(pd1.coordinate.X - pd2.coordinate.X), (byte)(pd1.coordinate.Y - pd2.coordinate.Y)));
        }

        //Հավասար վեկտորներն ունեն համապատասխան հավասար կոորդինատներ։ 
        //Եվ հակադարձը՝ եթե երկու վեկտորների համապատասխան կոորդինատները
        //հավասար են, ապա այդ վեկտորները հավասար են։


        public static bool operator ==(GeometricVector pd1, GeometricVector pd2)
        {
            if (pd1 == null || pd2 == null)
            {
                return false;
            }
            if ((pd1.coordinate.X == pd2.coordinate.X) && (pd2.coordinate.Y == pd2.coordinate.Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(GeometricVector pd1, GeometricVector pd2)
        {
            if (pd1 == null || pd2 == null)
            {
                return false;
            }
            if ((pd1.coordinate.X != pd2.coordinate.X) || (pd2.coordinate.Y != pd2.coordinate.Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false; //inchu exeption chenq throw anum????
            }
            var p = obj as GeometricVector;
            if (p == null)
            {
                return false;
            }
            return ((this.coordinate.X==p.coordinate.X) && (this.coordinate.Y==p.coordinate.Y));
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
