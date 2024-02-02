namespace UnitTests
{
    /// <summary>
    /// Тестирование класса круга.
    /// </summary>
    [TestClass]
    public class CircleTests
    {
        /// <summary>
        /// Проверка на корректный вывод исключения при отрицательном или нулевом радиусе.
        /// <param name="radius">Радиус.</param>
        /// </summary>
        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(-0.3)]
        [ExpectedException(typeof(ArgumentException))]
        public void Circle_RadiusIsNullOrLessZero_ThrowException(double radius)
        {
            var circle = new Circle(radius);
        }

        /// <summary>
        /// Провекрка на корректное вычисление площади.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        /// <param name="area">Площадь.</param>
        [TestMethod]
        [DataRow(1, 3.141592653589793)]
        [DataRow(5, 78.53981633974483)]
        public void CalculateArea_Radius_ReturnArea(double radius, double area)
        {
            var circle = new Circle(radius);

            var result = circle.CalculateArea();

            Assert.AreEqual(area, result);
        }
    }
}