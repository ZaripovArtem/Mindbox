namespace UnitTests
{
    /// <summary>
    /// ������������ ������ �����.
    /// </summary>
    [TestClass]
    public class CircleTests
    {
        /// <summary>
        /// �������� �� ���������� ����� ���������� ��� ������������� ��� ������� �������.
        /// <param name="radius">������.</param>
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
        /// ��������� �� ���������� ���������� �������.
        /// </summary>
        /// <param name="radius">������.</param>
        /// <param name="area">�������.</param>
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