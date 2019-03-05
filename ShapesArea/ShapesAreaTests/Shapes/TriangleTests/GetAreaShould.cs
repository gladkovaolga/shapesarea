using ShapesArea.Shapes;
using Xunit;

namespace ShapesAreaTests.Shapes.TriangleTests
{
    public class GetAreaShould
    {
		[Theory]
		[InlineData(3, 4, 5, 6)]
		[InlineData(5, 5, 6, 12)]
		[InlineData(5, 5, 8, 12)]
		[InlineData(6, 8, 10, 24)]
		[InlineData(10, 10, 12, 48)]
		[InlineData(5, 12, 13, 30)]
		public void ReturnTriangleArea(double side1, double side2, double side3, double expectedArea)
		{
			var triangle = new Triangle(side1, side2, side3);

			var area = triangle.GetArea();
			
			Assert.Equal(expectedArea, area);
		}
		
		[Theory]
		[InlineData(3, 4, 10)]
		[InlineData(5, 5, 100)]
		[InlineData(5, -5, 8)]
		[InlineData(6, 8, -10)]
		[InlineData(0, 4, 6)]
		[InlineData(0, 4, -6)]
		public void ReturnZeroIfTriangleIsInvalid(double side1, double side2, double side3)
		{
			var triangle = new Triangle(side1, side2, side3);

			var area = triangle.GetArea();
			
			Assert.Equal(0, area);
		}
	}
}
