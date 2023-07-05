using Mindbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class CircleTest
    {
        [Fact]
        public void GetAreaTest1()
        {
            Circle circle = new Circle(5);
            Assert.Equal(5 * 5 * Math.PI, circle.GetArea());
        }

        [Fact]
        public void GetAreaTest2()
        {
            Circle circle = new Circle(8);
            Assert.Equal(8 * 8 * Math.PI, circle.GetArea());
        }
    }
}
