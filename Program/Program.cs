using GeometryLibrary;

class Program
{
    static void Main()
    {
        // Создаем круг и вычисляем его площадь
        IShape? circle = Circle.GetCircle(0.0);
        if (circle != null) 
        {
            Console.WriteLine("Площадь - {0}: {1} ", circle.Name, circle.CalculateArea());
        }
        else
        {
            Console.WriteLine("Такая фигура не может существовать");
        }

        // Создаем треугольник и вычисляем его площадь
        IShape? triangle = Triangle.GetTriangle (3.0, 4.0, 5.0);
        if (triangle != null)
        {
            Console.WriteLine("Площадь - {0}: {1} ", triangle.Name, triangle.CalculateArea());
        }
        else
        {
            Console.WriteLine("Такая фигура не может существовать");
        }

        if (triangle is Triangle triangleObj)
        {
            if (triangleObj.IsRightTriangle())
            {
                Console.WriteLine("Треугольник является прямоугольным.");
            }
            else
            {
                Console.WriteLine("Треугольник не является прямоугольным.");
            }
        }
    }
}
