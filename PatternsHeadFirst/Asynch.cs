using System;
using System.Threading;
using System.Threading.Tasks;

namespace PatternsHeadFirst
{
    class Asynch
    {
        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Thread.Sleep(8000);

            return result;
        }
        // определение асинхронного метода
        static async Task<int> FactorialAsync(int n)
        {
            return await Task.Run(() => Factorial(n));   // выполняется асинхронно
        }

        static async Task Main(string[] args)
        {
            int n1 = await FactorialAsync(5);   // вызов асинхронного метода
            int n2 = await FactorialAsync(6);   // вызов асинхронного метода

            Console.WriteLine("Введите число: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат числа равен {n * n}");

            Console.Read();
        }
    }
}
