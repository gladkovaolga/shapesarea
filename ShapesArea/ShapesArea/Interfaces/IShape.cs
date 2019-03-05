using System;

namespace ShapesArea.Interfaces
{
	/// <summary>
	/// Геометрическая фигура
	/// </summary>
    public interface IShape
    {
		/// <summary>
		/// Вычислить площадь фигуры
		/// </summary>
		/// <returns>Площадь фигуры</returns>
		double GetArea();
    }
}
