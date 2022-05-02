using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingMethodsLab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(0, 2));
            points.Add(new Point(1, 3));
            points.Add(new Point(2, 2));
            points.Add(new Point(0, 2));
            try
            {
                Rectangle rectangle = new Rectangle(points);
                Console.WriteLine(rectangle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
