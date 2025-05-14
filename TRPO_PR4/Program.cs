using System;

namespace PointInSpace
{
    class Point
    {
        // Поля класса - координаты точки
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // Конструктор класса
        public Point(double x = 0, double y = 0, double z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Метод для ввода координат точки
        public void Input()
        {
            Console.Write("Введите координату X: ");
            X = double.Parse(Console.ReadLine());
            
            Console.Write("Введите координату Y: ");
            Y = double.Parse(Console.ReadLine());
            
            Console.Write("Введите координату Z: ");
            Z = double.Parse(Console.ReadLine());
        }

        // Метод для вывода координат точки
        public void Print()
        {
            Console.WriteLine($"Координаты точки: ({X}, {Y}, {Z})");
        }

        // Метод вычисления расстояния до другой точки
        public double DistanceTo(Point other)
        {
            return Math.Sqrt(
                Math.Pow(X - other.X, 2) + 
                Math.Pow(Y - other.Y, 2) + 
                Math.Pow(Z - other.Z, 2));
        }

        // Метод вычисления расстояния до начала координат
        public double DistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        // Метод для вывода информации о точке
        public void PrintInfo()
        {
            Print();
            Console.WriteLine($"Расстояние до начала координат: {DistanceToOrigin():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Точка в пространстве";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            // Создаем первую точку
            Point point1 = new Point();
            Console.WriteLine("Введите координаты первой точки:");
            point1.Input();

            // Создаем вторую точку для сравнения
            Point point2 = new Point();
            Console.WriteLine("\nВведите координаты второй точки:");
            point2.Input();

            // Выводим информацию о точках
            Console.WriteLine("\nИнформация о первой точке:");
            point1.PrintInfo();

            Console.WriteLine("\nИнформация о второй точке:");
            point2.PrintInfo();

            // Вычисляем расстояние между точками
            Console.WriteLine($"\nРасстояние между точками: {point1.DistanceTo(point2):F2}");

            Console.ReadKey();
        }
    }
}