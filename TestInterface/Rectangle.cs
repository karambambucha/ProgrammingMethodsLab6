using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInterface
{
	internal class Rectangle
	{
		public List<Point> points { private set; get; }
		private List<double> sides { set; get; }
		private List<double> angles { set; get; }
		public string FigureType { private set; get; }
		private void RearrangePoints()
		{
			double a1 = points[0].Y - points[2].Y;
			double a2 = points[1].Y - points[3].Y;
			double b1 = points[2].X - points[0].X;
			double b2 = points[3].X - points[1].X;
			if ((a1 / a2 < 0 && (double.IsNaN(b1 / b2)|| double.IsInfinity(b1 / b2)) ) || ((double.IsNaN(a1 / a2) || double.IsInfinity(a1 / a2)) && b1 / b2 < 0))
			{
				(points[1], points[2]) = (points[2], points[1]);
			}
			else if ((a1 / a2 > 0 && (double.IsNaN(b1 / b2) || double.IsInfinity(b1 / b2))) || ((double.IsNaN(a1 / a2) || double.IsInfinity(a1 / a2)) && b1 / b2 > 0))
			{
				(points[2], points[3]) = (points[3], points[2]);
			}
		}
		private void CalculateSides()
		{
			sides = new List<double>();
			double X1 = points[0].X;
			double X2 = points[1].X;
			double X3 = points[2].X;
			double X4 = points[3].X;
			double Y1 = points[0].Y;
			double Y2 = points[1].Y;
			double Y3 = points[2].Y;
			double Y4 = points[3].Y;
			sides.Add(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)));
			sides.Add(Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2)));
			sides.Add(Math.Sqrt(Math.Pow(X4 - X3, 2) + Math.Pow(Y4 - Y3, 2)));
			sides.Add(Math.Sqrt(Math.Pow(X1 - X4, 2) + Math.Pow(Y1 - Y4, 2)));
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
			points = new List<Point>();
			points.Add(p1);
			points.Add(p2);
			points.Add(p3);
			points.Add(p4);
			RearrangePoints();
			CalculateSides();
			CalculateAngles();
			FigureType = BoxTest();
		}
		public Rectangle(List<Point> ps)
		{
			if (ps.Count == 4)
			{
				points = ps;
				RearrangePoints();
				CalculateSides();
				CalculateAngles();
				FigureType = BoxTest();
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
		public string BoxTest()
		{
			if (points[0] == points[1] || points[0] == points[2] || points[0] == points[3] || points[1] == points[2] || points[1] == points[3] || points[2] == points[3])
			{
				throw new ArgumentException("Некоторые точки дублируются!");
			}
			
			if (sides[0] == sides[2] && sides[1] == sides[3])
			{
				if (sides[0] == sides[1] && sides[1] == sides[2])
				{
					if (angles[0] == 90 && angles[1] == 90 && angles[2] == 90 && angles[3] == 90)
					{
						return "Квадрат";
					}
					return "Ромб";
				}
				else if (angles[0] == 90 && angles[1] == 90 && angles[2] == 90 && angles[3] == 90)
				{
					return "Прямоугольник";
				}
				return "Параллелограмм";
			}
			else if (IsParallel(points[0], points[1], points[2], points[3]) || IsParallel(points[1], points[2], points[3], points[0]))
			{
				if (sides[0] == sides[2] || sides[1] == sides[3])
				{
					return "Равнобедренная трапеция";
				}
				if (angles.Contains(90))
				{
					return "Прямоугольная трапеция";
				}
				return "Трапеция общего вида";
			}
			return  "Четырехугольник общего вида";
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
			foreach (var s in sides)
			{
				sides_str.Append($"{s}\n");
			}
			foreach (var a in angles)
			{
				angles_str.Append($"{a}\n");
			}
			return $"{FigureType} с точками:\n{points_str}Стороны:\n{sides_str}Углы:\n{angles_str}";
		}
	}
}
