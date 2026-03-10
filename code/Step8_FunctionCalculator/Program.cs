using System;
namespace Step8_FunctionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Калькулятор (с использованием функций)");
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\nРезультаты:");
            Console.WriteLine($"{num1} + {num2} = {Sum(num1, num2)}");
            Console.WriteLine($"{num1} - {num2} = {Subtract(num1, num2)}");
            Console.WriteLine($"{num1} * {num2} = {Multiply(num1, num2)}");
            if (num2 != 0)
            {
                Console.WriteLine($"{num1} / {num2} = {Divide(num1, num2)}");
            }
            else
            {
                Console.WriteLine($"{num1} / {num2} = Ошибка: деление на ноль!");
            }

            Console.WriteLine("\nКонец программы.");
        }
        static double Sum(double a, double b)
        {
            double result = a + b;
            return result;
        }
        static double Subtract(double a, double b)
        {
            return a - b; 
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}