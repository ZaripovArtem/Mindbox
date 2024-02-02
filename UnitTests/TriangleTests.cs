namespace UnitTests
{
    /// <summary>
    /// Тестирование класса треугольника.
    /// </summary>
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным.
        /// </summary>
        /// <param name="first">Первая сторона.</param>
        /// <param name="second">Вторая сторона.</param>
        /// <param name="third">Третья сторона.</param>
        /// <param name="result">True - является, false - нет.</param>
        [TestMethod]
        [DataRow(3, 4, 5, true)]
        [DataRow(5, 12, 13, true)]
        [DataRow(2, 3, 4, false)]
        public void Triangle_Sides_ReturnIsRightTriangle(double first, double second, double third, bool result)
        {
            var triangle = new Triangle(first, second, third);

            Assert.AreEqual(result, triangle.IsRightTriangle);
        }

        /// <summary>
        /// Проверка на корректное вычисление площади треугольника.
        /// </summary>
        /// <param name="first">Первая сторона.</param>
        /// <param name="second">Вторая сторона.</param>
        /// <param name="third">Третья сторона.</param>
        /// <param name="area">Площадь треугольника.</param>
        [TestMethod]
        [DataRow(3, 4, 5, 6)]
        [DataRow(10, 8, 6, 24)]
        [DataRow(15, 10, 7, 29.393876913398138)]
        [DataRow(3, 7, 5, 6.49519052838329)]
        public void CalculateArea_Sides_ReturnArea(double first, double second, double third, double area)
        {
            var triangle = new Triangle(first, second, third);

            var result = triangle.CalculateArea();

            Assert.AreEqual(area, result);
        }
    }
}
