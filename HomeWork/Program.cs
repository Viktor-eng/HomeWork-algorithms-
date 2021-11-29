using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        // Домашнее задание №3, выполнил Белянкин Виктор Леонидович 31 год, г. Томск
        // Задача №1. Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной
        // и не оптимизированной программы. Написать функции сортировки, которые возвращают количество операций.

        static void Main(string[] args)
        {
            int count = 0;

            int[] array = { 49, 42, 58, 7, 15 };

           Console.WriteLine("Массив до сортировки: ");

            for (int i = 0; i < array.Length; i++)             
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Вывод массива после сортировки : ");

            BubbleSort(array, count);

         
        }


        // метод обмена элементов
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка пузырьком
        static void BubbleSort(int[] array, int count)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        count++;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Количество операций: {count}");
        }
    }
}
