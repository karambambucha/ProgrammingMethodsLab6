using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrilateralTestInterface
{
    public class Point
    {
        public double X { set; get; }
        public double Y { set; get; }
        public Point(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }
        public override string ToString()
        {
            return $"{X}, {Y}";
        }
        public static bool operator ==(Point left, Point right)
        {
            if (object.ReferenceEquals(null, left))
                return object.ReferenceEquals(null, right);
            return left.Equals(right);
        }
        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }
    }
}
