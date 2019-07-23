using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Введення числа
            Console.WriteLine("Введіть число:\n");

#if false // Базова найвідоміша методика
            Console.Write("\ta = ");
            double a = double.Parse(Console.ReadLine().Replace(".", ","));

            // Перевірка
            if (a % 2 == 0)
            {
                Console.WriteLine("\nВведене число а - парне.\n");
            }
            else if (Math.Abs(a % 2) == 1)
            {
                Console.WriteLine("\nВведене число а - непарне.\n");
            }
            else
            {
                Console.WriteLine("\nВведене число а - дійсне.\n");
            }
#endif

#if false // 1-ша методина на основі побітової логіки, але лише для цілих чисел
            Console.Write("\tb = ");
            int b = int.Parse(Console.ReadLine());

            // взято з інтернету
            // нехай "b" деяке задане число, тоді:
            // b & 1 == 0 -> b - парне
            // b & 1 == 1 -> b - непарне

            // Перевірка
            if ((b & 1) == 0)
            {
                Console.WriteLine("\nВведене число b - парне.\n");
            }

            // Лише для перевірки другого виразу, бо можна було зробити все в одному операторі
            if ((b & 1) == 1)
            {
                Console.WriteLine("\nВведене число b - непарне.\n");
            }

            // Згідно математичного формулювання
            if (b == 0)
            {
                Console.WriteLine("\nВведене число b - ні парне ні непарне.\n");
            }
#endif

#if true // 2-га методина на основі побітової логіки, але лише для цілих чисел
            Console.Write("\tc = ");
            int c = int.Parse(Console.ReadLine());

            // виведено власноруч
            // нехай "с" деяке задане число, тоді:
            // вираз: с^(~1) => -c
            // але ЛИШЕ ДЛЯ НЕПАРНИХ даний вираз змінює знак на протилежний 
            // аналогічно виразу: ~N + 1 => -N
            // тоді можна сформулювати нову умову при якій
            // с^(~1) + с == 0 - визначатиме непарність числа

            // Перевірка
            if (((c ^ ~1) + c) == 0)
            {
                Console.WriteLine("\nВведене число c - непарне.\n");
            }
            else if (c == 0)
            {
                Console.WriteLine("\nВведене число c - ні парне ні непарне.\n");
            }
            else
            {
                Console.WriteLine("\nВведене число c - парне.\n");
            }
#endif

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
