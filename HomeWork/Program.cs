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
            int countBubleSort = 0;
            int countBubleSortOptimized = 0;

            int[] array = { 1, 2, 5, 3, 4};
            int[] array2 = { 1, 2, 5, 3, 4};

            Console.WriteLine("Массив до сортировки:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("\nВывод массива после сортировки:");

            BubbleSort(array, ref countBubleSort);                       // Вызываем метод неоптимизированной сортировки 


            BubbleSortOptimized(array2, ref countBubleSortOptimized);

            

            Console.WriteLine("\nВыводим массив после оптимизированной сортировки");
            
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }

            Console.WriteLine($"\nКоличество операций после оптимизации: {countBubleSortOptimized}\n");

        }


        // метод обмена элементов
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка пузырьком
        static void BubbleSort(int[] array, ref int count)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);

                    }
                }
                count++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
    
            Console.WriteLine();
            Console.WriteLine($"Количество операций: {count}");
        }

        public static void BubbleSortOptimized(int[] anArray, ref int countBubleSortOptimized)
        {


            for (int i = 0; i < anArray.Length; i++)
            {

                bool isChanged = false;


                for (int j = 0; j < anArray.Length - 1 - i; j++)
                {

                    if (anArray[j] > anArray[j + 1])
                    {

                        Swap(ref anArray[j], ref anArray[j + 1]);

                        isChanged = true;
                    }
                }

                countBubleSortOptimized++;

                if (isChanged == false)
                    break;


            }
        }
    }
}

