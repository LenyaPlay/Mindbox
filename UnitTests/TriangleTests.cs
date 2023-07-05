using Mindbox;

namespace UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void IsRightTest1()
        {
            Triangle triangle = new Triangle(8, 16, Math.Sqrt(320));
            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void IsRightTest2()
        {
            Triangle triangle = new Triangle(8, 16, 9);
            Assert.False(triangle.IsRight());
        }

        [Fact]
        public void GetAreaTest1()
        {
            Triangle triangle = new Triangle(8, 15, 17);
            Assert.Equal(60, triangle.GetArea());
        }

        [Fact]
        public void GetAreaTest2()
        {
            Triangle triangle = new Triangle(8, 15, 18);
            Assert.Equal(59.358550352918826, triangle.GetArea());
        }

        [Fact]
        public void ExistTest1()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        }

        [Fact]
        public void ExistTest2()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-5, 5, 6));
        }
    }
}