using System;
using ShapesArea.Interfaces;

namespace ShapesArea.Shapes
{
	/// <summary>
	/// Треугольник
	/// </summary>
	public class Triangle : IShape
    {
		/// <summary>
		/// Длина стороны треугольника
		/// </summary>
		public double Side1 { get; set; }

		/// <summary>
		/// Длина стороны треугольника
		/// </summary>
		public double Side2 { get; set; }

		/// <summary>
		/// Длина стороны треугольника
		/// </summary>
		public double Side3 { get; set; }

		/// <summary>
		/// Треугольник
		/// </summary>
		/// <param name="side1">Длина стороны треугольника</param>
		/// <param name="side2">Длина стороны треугольника</param>
		/// <param name="side3">Длина стороны треугольника</param>
		public Triangle(double side1, double side2, double side3)
		{
			Side1 = side1;
			Side2 = side2;
			Side3 = side3;
		}

		/// <inheritdoc />
		/// <remarks>
		/// Если для чисел Side1, Side2, Side3 не выполняется неравенство треугольника
		/// или одно из этих чисел неположительно, 
		/// будет возвращен ноль.
		/// </remarks>
		public double GetArea()
		{
			if (Side1 <= 0 || Side2 <= 0 || Side3 <= 0)
			{
				return 0;
			}

			if (Side1 + Side2 < Side3 ||
				Side1 + Side3 < Side2 ||
				Side2 + Side3 < Side1)
			{
				// Не выполняется неравенство треугольника
				return 0;
			}

			var p = (Side1 + Side2 + Side3) / 2;

			return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
		}

		/// <summary>
		/// Проверка, является ли треугольник прямоугольным
		/// </summary>
		public bool IsRightTriangle()
		{
			if (Side1 <= 0 || Side2 <= 0 || Side3 <= 0)
			{
				return false;
			}

			if (Side1 + Side2 < Side3 ||
				Side1 + Side3 < Side2 ||
				Side2 + Side3 < Side1)
			{
				// Не выполняется неравенство треугольника
				return false;
			}

			return 
				(Math.Pow(Side1, 2) == Math.Pow(Side2, 2) + Math.Pow(Side3, 2) ||
				 Math.Pow(Side2, 2) == Math.Pow(Side1, 2) + Math.Pow(Side3, 2) ||
				 Math.Pow(Side3, 2) == Math.Pow(Side1, 2) + Math.Pow(Side2, 2));
		}
	}
}
