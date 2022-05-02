using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInterface
{
	internal class Line : IComparable<Line>
	{
		public double X1 { private set; get; }
		public double X2 { private set; get; }
		public double Y { private set; get; }
		public double length { private set; get; }
		
		public Line(Point p1, Point p2)
		{
			if (p1.X > p2.X) 
            {
				(p1, p2) = (p2,p1);
            }
			X1 = p1.X;
			X2 = p2.X;
			Y = p1.Y;
			length = (Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2)));
		}
		
		public override string ToString()
		{
			return $"X: ({X1}, {X2}), Y: {Y}. Длина: {length}";
		}

        public int CompareTo(Line other)
        {
            
			return X1.CompareTo(other.X1);
		}
    }
}
