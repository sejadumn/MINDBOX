
namespace GeometryLibrary
{
    // Класс для треугольника
    public class Triangle : IShape
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public string Name { get { if (IsRightTriangle()) return "Прямоугольный треугольник"; return "Треугольник"; }}

        private Triangle(double side1, double side2, double side3)
        {           
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        // Метод создает по возможности треугольник 
        public static Triangle? GetTriangle(double side1, double side2, double side3)
        {
            if (!CanFormTriangle(side1, side2, side3))
            {
                return null;
            }
            return new Triangle(side1, side2, side3);   
        }

        public static bool CanFormTriangle(double side1, double side2, double side3)
        {
            // Проверяем неравенство треугольника для всех трех пар сторон
            bool condition1 = (side1 + side2 > side3);
            bool condition2 = (side1 + side3 > side2);
            bool condition3 = (side2 + side3 > side1);

            // Если все три условия выполняются, треугольник может существовать
            return condition1 && condition2 && condition3;
        }

        // Переопределяем метод CalculateArea для треугольника
        public double CalculateArea()
        {
            // Используем формулу Герона для вычисления площади треугольника
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        // Метод для проверки, является ли треугольник прямоугольным
        public bool IsRightTriangle()
        {
            // Проверяем, удовлетворяет ли треугольник теореме Пифагора
            double[] sides = { Side1, Side2, Side3 };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
