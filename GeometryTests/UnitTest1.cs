using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

[TestClass]
public class GeometryTests
{
    [TestMethod]
    public void TestTriangleAreaCalculation()
    {
        // Arrange
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        double expectedArea = 6; // Площадь прямоугольного треугольника по формуле (a * b) / 2

        // Act
        Triangle triangle = Triangle.GetTriangle(side1, side2, side3);

        // Assert
        Assert.IsNotNull(triangle);
        Assert.AreEqual(expectedArea, triangle.CalculateArea(), 0.001); // Проверяем с точностью до 0.001
    }

    [TestMethod]
    public void TestCircleAreaCalculation()
    {
        // Arrange
        double radius = 5;
        double expectedArea = Math.PI * radius * radius;

        // Act
        Circle circle = Circle.GetCircle(radius);

        // Assert
        Assert.IsNotNull(circle);
        Assert.AreEqual(expectedArea, circle.CalculateArea(), 0.001); // Проверяем с точностью до 0.001
    }

    [TestMethod]
    public void TestInvalidTriangle()
    {
        // Arrange
        double side1 = 1;
        double side2 = 2;
        double side3 = 3;

        // Act
        Triangle triangle = Triangle.GetTriangle(side1, side2, side3);

        // Assert
        Assert.IsNull(triangle); // Проверяем, что треугольник не может быть создан
    }

    [TestMethod]
    public void TestInvalidCircle()
    {
        // Arrange
        double radius = -1;

        // Act
        Circle circle = Circle.GetCircle(radius);

        // Assert
        Assert.IsNull(circle); // Проверяем, что окружность не может быть создана с отрицательным радиусом
    }
}
