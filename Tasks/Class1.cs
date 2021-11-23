using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public static class Menu_start
    {
        public static void Menu()
        {
            Console.WriteLine("Добрый день, для проверки введите номер задачи");
            Console.WriteLine();
            Console.WriteLine("Задача №1. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела по формуле I=m/(h*h); где m-масса " +
                "тела в килограммах, h - рост в метрах");
            Console.WriteLine();
            Console.WriteLine("Задача №2. Найти максимальное из четырех чисел. Массивы не использовать.");
            Console.WriteLine();
            Console.WriteLine("Задача №3. Написать программу обмена значениями двух целочисленных переменных с использованием третьей переменной");
            Console.WriteLine();
            Console.WriteLine("Задача №4. Написать программу обмена значениями двух целочисленных переменных без использования третьей переменной");
            Console.WriteLine();
            Console.WriteLine("Задача №5. С клавиатуры вводится номер месяца. Требуется определить, к какому времени года он относится");
            Console.WriteLine();
        }
    }
    public class Tasks
    {
        public static void Task_1()
        {
            Console.WriteLine("Добрый день, пожалуйста укажите свой вес");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Пожалуйста укажите свой рост");
            double h = Convert.ToDouble(Console.ReadLine());

            double I = m / ((h / 100) * (h / 100));

            Console.WriteLine($"Индекс массы вышего тела {I}");

            if (I >= 18 && I <= 24)
            {
                Console.WriteLine("Ваш вес в норме");
            }

            else if (I >= 25 && I <= 30)
            {
                Console.WriteLine("Вам необходимо похудеть");
            }

            else if (I <= 16 && I <= 18)
            {
                Console.WriteLine("Вам необходимо набрать вес");
            }
            Console.ReadKey();

        }
        public static void Task_2()
        {
            Console.WriteLine("Введите число №1");
            int valueA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число №2");
            int valueB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число №3");
            int valueC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число №3");
            int valueD = Convert.ToInt32(Console.ReadLine());

            int result;

            if (valueA > valueB && valueA > valueC && valueA > valueD)
            {
                result = valueA;
            }

            else if (valueB > valueC && valueB > valueD)
            {
                result = valueB;
            }
            else if (valueC > valueD)
            {
                result = valueC;
            }
            else
            {
                result = valueD;
            }

            Console.WriteLine($"Максимальное число = {result}");
            Console.ReadKey();
        }

        public static void Task_3()
        {
            Console.WriteLine("Введите переменную a");          // 1) Решение задачи с использованием третьей переменной;
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите переменную b");
            int b = Convert.ToInt32(Console.ReadLine());

            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.ReadKey();
        }
        public static void Task_4()
        {
            Console.WriteLine("Введите переменную a");          // 1) Решение задачи без использования третьей переменной;
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите переменную b");
            int b = Convert.ToInt32(Console.ReadLine());

            a = (a + b);
            b = a - b;
            a = a - b;

            Console.WriteLine($"a = {a}, b = {b}");
            Console.ReadKey();

        }

        public static void Task_5()
        {
            Console.WriteLine("Введите номер месяца");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1 || a == 2 || a == 3)
            {
                Console.WriteLine($"Время года - Зима");
            }

            else if (a == 4 || a == 5 || a == 6)
            {
                Console.WriteLine($"Время года - Весна");
            }

            else if (a == 7 || a == 8 || a == 9)
            {
                Console.WriteLine($"Время года - Лето");
            }

            else if  (a == 10 || a == 11 || a == 12)
            {
                Console.WriteLine($"Время года - Осень");
            }

            else
            {
                Console.WriteLine("Число некорректно");
            }
        }
    }
}

