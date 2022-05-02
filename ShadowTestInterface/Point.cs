using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    internal class Point
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
            if (left.X == right.X && left.Y == right.Y)
                return true;
            else
                return false;
        }
        public static bool operator !=(Point left, Point right)
        {
            if (left.X == right.X && left.Y == right.Y)
                return false;
            else
                return true;
        }
    }
}
