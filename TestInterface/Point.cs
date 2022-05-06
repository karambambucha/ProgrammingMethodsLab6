using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationTestInterface
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
            if (left is null || right is null)
                return left is null && right is null;
            return left.X == right.X && left.Y == right.Y;
        }
        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }
    }
}
