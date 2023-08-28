
namespace GeometryLibrary
{
    // Класс для круга
    public class Circle : IShape
    {
        public double Radius { get; }
        public string Name { get { return "Окружность"; } }
        private Circle(double radius)
        {
            Radius = radius;
        }
        public static Circle? GetCircle(double radius)
        {
            if (radius <= 0)
            {
                return null;
            }
            return new Circle(radius);
        }

        // Переопределяем метод CalculateArea для круга
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
