using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // створення випадкових змінних в відповідному діапазоні
            Random rnd = new Random();

            // Індентифікатори для прикладу
            int a = rnd.Next(short.MinValue, short.MaxValue),
                b = rnd.Next(short.MinValue, short.MaxValue);

            // Виведення змінних
            Console.WriteLine("Випадкові змінні:");
            Console.WriteLine($"A = {a:N0}");
            Console.WriteLine($"B = {b:N0}");

            // Результати розрахунків
            // За базовою формулою A | B
            Console.WriteLine($"\nРезультат: A | B = {a | b:N0};");
            // За еквівалентною формулою на основі теореми Де Моргана
            // A | B = ~(~(A | B)) = ~(~A & ~B)
            Console.WriteLine($"\nРезультат: ~(~A & ~B) = {~(~a & ~b):N0};");

            #region Повторення
            Console.WriteLine("\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey();

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
            }
            #endregion
        }
    }
}
