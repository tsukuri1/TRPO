using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите метод расчета:");
        Console.WriteLine("1. Цикл for");
        Console.WriteLine("2. Цикл while");
        Console.WriteLine("3. Цикл do...while");
        Console.Write("Ваш выбор (1-3): ");
        
        int choice = int.Parse(Console.ReadLine());
        
        Console.Write("Введите значение X: ");
        double X = double.Parse(Console.ReadLine());
        
        Console.Write("Введите значение Y: ");
        double Y = double.Parse(Console.ReadLine());
        
        Console.Write("Введите количество слагаемых: ");
        int n = int.Parse(Console.ReadLine());
        
        double rho = 0;
        
        switch (choice)
        {
            case 1:
                rho = CalculateWithFor(X, Y, n);
                break;
            case 2:
                rho = CalculateWithWhile(X, Y, n);
                break;
            case 3:
                rho = CalculateWithDoWhile(X, Y, n);
                break;
            default:
                Console.WriteLine("Неверный выбор метода.");
                return;
        }
        
        Console.WriteLine($"Результат: p = {rho}");
    }
    
    static double CalculateWithFor(double X, double Y, int n)
    {
        double result = 0;
        for (int i = 0; i < n; i++)
        {
            int k = 2 * i + 1; // Нечетные числа
            double term;
            
            if (i % 2 == 0) // Четные индексы
            {
                term = Math.Pow(X, k) / (k * (k + 1) * (k + 2));
            }
            else // Нечетные индексы
            {
                term = Math.Pow(Y, k) / (k * (k + 1) * (k + 2));
            }
            
            result += term;
        }
        return result;
    }
    
    static double CalculateWithWhile(double X, double Y, int n)
    {
        double result = 0;
        int i = 0;
        while (i < n)
        {
            int k = 2 * i + 1;
            double term;
            
            if (i % 2 == 0)
            {
                term = Math.Pow(X, k) / (k * (k + 1) * (k + 2));
            }
            else
            {
                term = Math.Pow(Y, k) / (k * (k + 1) * (k + 2));
            }
            
            result += term;
            i++;
        }
        return result;
    }
    
    static double CalculateWithDoWhile(double X, double Y, int n)
    {
        double result = 0;
        int i = 0;
        do
        {
            int k = 2 * i + 1;
            double term;
            
            if (i % 2 == 0)
            {
                term = Math.Pow(X, k) / (k * (k + 1) * (k + 2));
            }
            else
            {
                term = Math.Pow(Y, k) / (k * (k + 1) * (k + 2));
            }
            
            result += term;
            i++;
        } while (i < n);
        return result;
    }
}