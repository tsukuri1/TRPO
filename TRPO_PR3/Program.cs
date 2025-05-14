using System;

namespace MatrixProcessing
{
    class Program
    {
        static void Main()
        {
            // Ввод размеров матрицы
            Console.Write("Введите количество строк (M): ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов (N): ");
            int N = int.Parse(Console.ReadLine());

            // Создание и заполнение матрицы случайными числами
            int[,] matrix = new int[M, N];
            Random rand = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(1, 101); // числа от 1 до 100 для простоты
                }
            }

            // Вывод исходной матрицы
            Console.WriteLine("\nИсходная матрица:");
            PrintMatrix(matrix, M, N);

            // Находим минимальный элемент матрицы
            int min = matrix[0, 0];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
            }
            Console.WriteLine($"\nМинимальный элемент матрицы: {min}");

            // Создаем копию матрицы для изменений
            int[,] resultMatrix = (int[,])matrix.Clone();

            // Обрабатываем каждую строку
            for (int i = 0; i < M; i++)
            {
                // Вычисляем среднее арифметическое строки
                int sum = 0;
                for (int j = 0; j < N; j++)
                {
                    sum += matrix[i, j];
                }
                double average = (double)sum / N;

                // Заменяем элементы больше среднего на минимальный
                for (int j = 0; j < N; j++)
                {
                    if (resultMatrix[i, j] > average)
                        resultMatrix[i, j] = min;
                }
            }

            // Вывод результирующей матрицы
            Console.WriteLine("\nРезультирующая матрица:");
            PrintMatrix(resultMatrix, M, N);
        }

        // Метод для вывода матрицы
        static void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(4) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}