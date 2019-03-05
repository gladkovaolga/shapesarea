using System;
using ShapesArea.Shapes;
using Xunit;

namespace ShapesAreaTests.Shapes.CircleTests
{
    public class GetAreaShould
    {
		[Theory]
		[InlineData(1)]
		[InlineData(10)]
		[InlineData(25)]
		[InlineData(1000)]
		[InlineData(0.5)]
		[InlineData(3.14)]
		public void ReturnCircleArea(double radius)
		{
			var circle = new Circle(radius);

			var area = circle.GetArea();
			var expectedArea = Math.PI * Math.Pow(radius, 2);

			Assert.Equal(expectedArea, area);
		}

		[Theory]
		[InlineData(0)]
		[InlineData(-1)]
		[InlineData(-25)]
		[InlineData(-1000)]
		[InlineData(-0.5)]
		[InlineData(-3.14)]
		public void ReturnZeroIfCircleIsInvalid(double radius)
		{
			var circle = new Circle(radius);

			var area = circle.GetArea();
			
			Assert.Equal(0, area);
		}
	}
}
