using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp4
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Введення числа
            Console.WriteLine("Програма розрахунку премій співробітникам\n");
            Console.WriteLine("\n\tВведіть дані співробітника: \n");
            Console.Write("\tЗаробітня платня (ЗП) співробітника: ");
            double salary = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.Write("\tДосвід співробітника (років): ");
            double expirience = double.Parse(Console.ReadLine().Replace(".", ","));

            // % - процент премії
            double bonus = 0;

            if (salary <= 0 || expirience < 0)
            {
                Console.WriteLine("\nЗП не можу бути меншою або рівною нулю або " +
                    "досвід меншим нуля!");
            }
            else if (0 <= expirience && expirience < 5)
            {
                bonus = 10;
            }
            else if (5 <= expirience && expirience < 10)
            {
                bonus = 15;
            }
            else if (10 <= expirience && expirience < 15)
            {
                bonus = 25;
            }
            else if (15 <= expirience && expirience < 20)
            {
                bonus = 35;
            }
            else if (20 <= expirience && expirience < 25)
            {
                bonus = 45;
            }
            else // (25 <= expirience)
            {
                bonus = 50;
            }

            if (salary > 0 && expirience >= 0)
            {
                double premium = salary * bonus / 100;
                Console.WriteLine($"\nНарахована премія: {premium:N};");
                Console.WriteLine($"\nСума до виплати: {salary + premium:N};");
            }

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
