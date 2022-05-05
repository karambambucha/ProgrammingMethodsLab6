using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangelTestInterface
{
	public class Rectangle
	{
		public Point[] points { private set; get; }
		private List<double> sides { set; get; }
		private List<double> angles { set; get; }
		public string FigureType { private set; get; }
		public bool isQuadrilateral { private set; get; }
		private bool isCrossing(Point p1, Point p2, Point p3, Point p4)
		{
			if (p2.Y - p1.Y != 0)
			{
				double q = (p2.X - p2.X) / (p1.Y - p2.Y);
				double sn = (p3.X - p4.X) + ((p3.Y - p4.Y)) * q;
				if (sn == 0)
					return false;
			}
			else
			{
				if ((p3.Y - p4.Y) == 0)
					return false;
			}
			return true;
		}
		private void RearrangePoints()
		{
			if (isCrossing(points[0], points[1], points[2], points[3]))
				(points[1], points[2]) = (points[2], points[1]);
			else if (isCrossing(points[0], points[3], points[1], points[2]))
				(points[2], points[3]) = (points[3], points[2]);
		}
		private void CalculateSides()
		{
			sides = new List<double>();
			sides.Add(Math.Sqrt(Math.Pow(points[1].X - points[0].X, 2)
				+ Math.Pow(points[1].Y - points[0].Y, 2)));
			sides.Add(Math.Sqrt(Math.Pow(points[2].X - points[1].X, 2)
				+ Math.Pow(points[2].Y - points[1].Y, 2)));
			sides.Add(Math.Sqrt(Math.Pow(points[3].X - points[2].X, 2)
				+ Math.Pow(points[3].Y - points[2].Y, 2)));
			sides.Add(Math.Sqrt(Math.Pow(points[0].X - points[3].X, 2)
				+ Math.Pow(points[0].Y - points[3].Y, 2)));
		}
		private double GetAngle(Point A, Point C, Point B)
		{
			Point AC = new Point(C.X - A.X, C.Y - A.Y);
			Point BC = new Point(C.X - B.X, C.Y - B.Y);
			double cos = (AC.X * BC.X + AC.Y * BC.Y) / (Math.Sqrt(AC.X * AC.X + AC.Y * AC.Y) * Math.Sqrt(BC.X * BC.X + BC.Y * BC.Y));
			return Math.Acos(cos) * 180 / Math.PI;
		}
		private void CalculateAngles()
		{
			angles = new List<double>();
			angles.Add(GetAngle(points[0], points[1], points[2]));
			angles.Add(GetAngle(points[1], points[2], points[3]));
			angles.Add(GetAngle(points[2], points[3], points[0]));
			angles.Add(GetAngle(points[3], points[0], points[1]));
		}
		public Rectangle(Point p1, Point p2, Point p3, Point p4)
		{
			points = new Point[4];
			if (p1 == null || p2 == null || p3 == null || p4 == null)
				throw new ArgumentNullException();
			points[0] = p1;
			points[1] = p2;
			points[2] = p3;
			points[3] = p4;
			RearrangePoints();
			CalculateSides();
			CalculateAngles();
			FigureType = GetFigureType();
		}
		public Rectangle(List<Point> ps)
		{
			if (ps.Count == 4)
			{
				points = ps.ToArray();
				RearrangePoints();
				CalculateSides();
				CalculateAngles();
				FigureType = GetFigureType();
			}
			else
			{
				throw new ArgumentException($"Неверное количество точек! Передано {ps.Count} точек");
			}
		}
		private bool IsParallel(Point p1, Point p2, Point p3, Point p4)
		{
			double k1 = (p2.Y - p1.Y) / (p2.X - p1.X);
			double k2 = (p4.Y - p3.Y) / (p4.X - p3.X);
			return (k1 == k2);
		}
		public string GetFigureType()
		{
			isQuadrilateral = true;
			if (points[0] == points[1] || points[0] == points[2] || points[0] == points[3] || points[1] == points[2] || points[1] == points[3] || points[2] == points[3])
				throw new ArgumentException("Некоторые точки дублируются!");
			if (angles.Contains(180) || angles.Contains(0))
			{
				isQuadrilateral = false;
				return "Не четырехугольник";
			}
			if (sides[0] == sides[2] && sides[1] == sides[3])
			{
				if (sides[0] == sides[1] && sides[1] == sides[2])
				{
					if (angles.All(x => x == 90))
						return "Квадрат";
					else
						return "Ромб";
				}
				else if (angles.All(x => x == 90))
					return "Прямоугольник";
				else
					return "Параллелограмм";
			}
			else if (IsParallel(points[0], points[1], points[2], points[3]) || IsParallel(points[1], points[2], points[3], points[0]))
			{
				if (sides[0] == sides[2] || sides[1] == sides[3])
					return "Равнобедренная трапеция";
				else if (angles.Contains(90))
					return "Прямоугольная трапеция";
				else
					return "Трапеция общего вида";
			}
			else
				return "Четырехугольник общего вида";
		}
		public override string ToString()
		{
			StringBuilder points_str = new StringBuilder();
			StringBuilder sides_str = new StringBuilder();
			StringBuilder angles_str = new StringBuilder();
			foreach (var p in points)
			{
				points_str.Append($"[{p}]\n");
			}
			if (isQuadrilateral)
			{
				foreach (var s in sides)
				{
					sides_str.Append($"{s}\n");
				}
				foreach (var a in angles)
				{
					angles_str.Append($"{a}\n");
				}
			}
			return $"{FigureType} с точками:\n{points_str}Стороны:\n{sides_str}Углы:\n{angles_str}";
		}
	}
}
