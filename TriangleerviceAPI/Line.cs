using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace TriangleServiceAPI
{
    public class Line
    {
        public double Length { get; set; }
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Line(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
            Length = GetDistance(point1, point2);
        }

        private double GetDistance(Point point1, Point point2)
        {
            //a^2 + b^2 = c^2
            var a = point2.X - point1.X;
            var b = point2.Y - point2.Y;

            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
