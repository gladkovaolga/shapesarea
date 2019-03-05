using System;
using ShapesArea.Interfaces;

namespace ShapesArea.Shapes
{
	/// <summary>
	/// Круг
	/// </summary>
    public class Circle : IShape
    {
		/// <summary>
		/// Радиус круга
		/// </summary>
		public double Radius { get; set; }

		/// <summary>
		/// Круг
		/// </summary>
		/// <param name="radius">Радиус круга</param>
		public Circle(double radius)
		{
			Radius = radius;
		}

		/// <inheritdoc />
		/// <remarks>
		/// Если радиус круга неположительный, будет возвращён ноль.
		/// </remarks>
		public double GetArea()
		{
			if (Radius <= 0)
			{
				return 0;
			}

			return Math.PI * Math.Pow(Radius, 2);
		}
    }
}
