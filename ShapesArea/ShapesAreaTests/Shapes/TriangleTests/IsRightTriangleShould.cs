using ShapesArea.Shapes;
using Xunit;

namespace ShapesAreaTests.Shapes.TriangleTests
{
    public class IsRightTriangleShould
    {
		[Theory]
		[InlineData(3, 4, 5)]
		[InlineData(5, 12, 13)]
		[InlineData(8, 15, 17)]
		[InlineData(7, 24, 25)]
		public void ReturnTrueIfTriangleIsRight(double side1, double side2, double side3)
		{
			var triangle = new Triangle(side1, side2, side3);

			var isRightTriangle = triangle.IsRightTriangle();

			Assert.True(isRightTriangle);
		}
		
		[Theory]
		[InlineData(3, 4, 6)]
		[InlineData(5, 12, 14)]
		[InlineData(8, 15, 18)]
		[InlineData(7, 24, 26)]
		public void ReturnFalseIfTriangleIsNotRight(double side1, double side2, double side3)
		{
			var triangle = new Triangle(side1, side2, side3);

			var isRightTriangle = triangle.IsRightTriangle();

			Assert.False(isRightTriangle);
		}

		[Theory]
		[InlineData(3, 4, 10)]
		[InlineData(5, 12, -14)]
		[InlineData(8, -15, 18)]
		[InlineData(0, 24, 26)]
		public void ReturnFalseIfTriangleIsInvalid(double side1, double side2, double side3)
		{
			var triangle = new Triangle(side1, side2, side3);

			var isRightTriangle = triangle.IsRightTriangle();

			Assert.False(isRightTriangle);
		}
	}
}
