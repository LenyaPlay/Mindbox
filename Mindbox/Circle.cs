using System;
using System.Collections.Generic;
using System.Text;

namespace Mindbox
{
    public class Circle : IFigure
    {
        public double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public double GetArea()
        {
            return Math.PI * r * r;
        }
    }
}
