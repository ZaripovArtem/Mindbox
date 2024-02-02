using Area.Interfaces;

namespace Area.Figures
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : IArea
    {
        /// <summary>
        /// Радиус.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Инициализация фигуры.
        /// </summary>
        /// <param name="radius">Радиус фигуры.</param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус круга не может быть меньше или равен нулю.", nameof(radius));
            }

            Radius = radius;
        }

        /// <summary>
        /// Вычисление площади фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
