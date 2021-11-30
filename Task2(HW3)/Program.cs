﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_HW3_
{
    class Program
    {
        static void Main(string[] args)
        {
        // Домашнее задание №3, выполнил Белянкин Виктор Леонидович 31 год, г.Томск
        // Задача №2. *Реализовать шейкерную сортировку.

            int[] array = { 10, 20, 15, 18, 16, 31 };
            Console.WriteLine($"Шейкерная сортировка");
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            ShakerSort(array);
            Console.WriteLine();
            Console.Write("\nВыводим массив после сортировки:\n");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            

            Console.ReadLine();
        }

        //метод обмена элементов
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка перемешиванием
        static int[] ShakerSort(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;
                //проход слева направо
                for (var j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }

                //проход справа налево
                for (var j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        swapFlag = true;
                    }
                }

                //если обменов не было выходим
                if (!swapFlag)
                {
                    break;
                }
            }

            return array;
        }



    }
}