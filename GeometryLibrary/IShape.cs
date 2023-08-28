
namespace GeometryLibrary
{
    // Определяем интерфейс
    public interface IShape
    {
        // Метод для вычисления площади фигуры
        double CalculateArea();
        string Name { get; }

    }
}