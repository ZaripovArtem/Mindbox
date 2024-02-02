using Area.Interfaces;

namespace Area.Figures
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : IArea
    {
        /// <summary>
        /// Первая сторона.
        /// </summary>
        public double First { get; set; }

        /// <summary>
        /// Вторая сторона.
        /// </summary>
        public double Second { get; set; }

        /// <summary>
        /// Третья сторона.
        /// </summary>
        public double Third { get; set; }

        /// <summary>
        /// Является ли треугольник прямоугольным.
        /// </summary>
        public bool IsRightTriangle = false;

        /// <summary>
        /// Инициализация треугольника.
        /// </summary>
        /// <param name="first">Первая сторона.</param>
        /// <param name="second">Вторая сторона.</param>
        /// <param name="third">Третья сторона.</param>
        public Triangle(double first, double second, double third)
        {
            if (first <= 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть меньше или равна нулю.", nameof(first));
            }

            if (second <= 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть меньше или равна нулю.", nameof(second));
            }

            if (third <= 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть меньше или равна нулю.", nameof(third));
            }

            if (!(first + second > third && second + third > first && first + third > second))
            {
                throw new ArgumentException("Треугольника с заданными параметрами не существует.");
            }

            if (first * first + second * second == third * third
                || first * first + third * third == second * second
                || third * third + second * second == first * first)
            {
                IsRightTriangle = true;
            }

            First = first;
            Second = second;
            Third = third;
        }

        /// <summary>
        /// Вычисление площади фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public double CalculateArea()
        {
            if (IsRightTriangle)
            {
                if (First > Second && First > Third)
                {
                    return Second * Third / 2;
                }
                else
                {
                    return (Second > First && Second > Third) 
                        ? First * Third / 2 
                        : First * Second / 2;
                }
            }

            double semiperimeter = (First + Second + Third) / 2;

            return Math.Sqrt(semiperimeter * (semiperimeter - First) * (semiperimeter - Second) * (semiperimeter - Third));
        }
    }
}
