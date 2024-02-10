using System;

namespace GeometryLibrary
{
    public class Triangle : IShape
    {
        private double _side1, _side2, _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double GetArea()
        {
            double s = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
        }

        public bool IsRightAngleTriangle()
        {
            return Math.Pow(_side1, 2) + Math.Pow(_side2, 2) == Math.Pow(_side3, 2) ||
                   Math.Pow(_side1, 2) + Math.Pow(_side3, 2) == Math.Pow(_side2, 2) ||
                   Math.Pow(_side2, 2) + Math.Pow(_side3, 2) == Math.Pow(_side1, 2);
        }
    }
}
