using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_HW3_
{
    class Program
    {
        // Домашнее задание №3, выполнил Белянкин Виктор Леонидович 31 год, г.Томск
        // Задача №3.  Реализовать бинарный алгоритм поиска в виде функции, которой передается отсортированный массив.
        // Функция возвращает индекс найденного элемента или -1, если элемент не найден..

        static void Main(string[] args)
        {
            Console.WriteLine("Бинарный поиск(рекурсивная реализация)");
            int[] array = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Дан отсортированный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
           
            while (true)
            {
                Console.Write("\nВведите искомое значение или -777 для выхода: ");
                var k = Convert.ToInt32(Console.ReadLine());
                if (k == -777)
                {
                    break;
                }

                var searchResult = BinarySearch(array, k, 0, array.Length - 1);
                if (searchResult < 0)
                {
                    Console.WriteLine(-1 +" "+"Элемент не найден");
                }
                else
                {
                    Console.WriteLine("Элемент найден. Индекс элемента со значением {0} равен {1}", k, searchResult);
                }
            }

            Console.ReadLine();
        }

        //метод для рекурсивного бинарного поиска
        static int BinarySearch(int[] array, int searchedValue, int first, int last)
        {
            //границы сошлись
            if (first > last)
            {
                //элемент не найден
                return -1;
            }

            //средний индекс подмассива
            var middle = (first + last) / 2;
            //значение в средине подмассива
            var middleValue = array[middle];

            if (middleValue == searchedValue)
            {
                return middle;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    //рекурсивный вызов поиска для левого подмассива
                    return BinarySearch(array, searchedValue, first, middle - 1);
                }
                else
                {
                    //рекурсивный вызов поиска для правого подмассива
                    return BinarySearch(array, searchedValue, middle + 1, last);
                }
            }

        }
    }
}
