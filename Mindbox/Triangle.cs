using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;

namespace Mindbox
{
    public class Triangle : IFigure
    {
        public double a = double.NaN;
        public double b = double.NaN;
        public double c = double.NaN;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            //Обработка на нули нужна? Если нужна,то можно так
            if (a < 0 || b < 0 || c < 0 || a + b <= c || a + c <= b || c + b <= a)
                throw new ArgumentException("Такого треугольника не существует");
        }

        public double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRight()
        {
            double eps = 0.0000000000001;
            double aa = a * a;
            double bb = b * b;
            double cc = c * c;
            return Math.Abs(aa + bb - cc) <= eps || Math.Abs(aa - bb + cc) <= eps || Math.Abs(-aa + bb + cc) <= eps;
        }
    }
}
