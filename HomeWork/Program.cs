using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        // Задание выполнил Белянкин Виктор Леонидович,  31 год, г. Томск
        // Задача №1 Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.
        static void Main(string[] args)
        {
            double fixNumber;
            double number = fixNumber = 156;
            TestCheck(number, fixNumber);
        }


        static void TestCheck(double number, double fixNumber)
        {
            int i;

            for (i = 0; number > 1; i++)         // Считаем сколько элементов в массиве
            {
                
                if (number % 2 != 0)
                {
                    number = Math.Floor(number);
                }
                number = number / 2;
            }

            double[] array = new double[i];          // Создаем массив
            double fixNumber2 = fixNumber;

            for (int j = 0; fixNumber > 1; j++)  // Записываем в массив числов двоичной системе
            {
                
                fixNumber = Math.Floor(fixNumber / 2);
                fixNumber2 = fixNumber % 2;
                           
                array[j] = fixNumber2;
              
            }


            for (int k = array.Length-1; k != 0; k--)  // выводим в обратном порядке
            {
                Console.Write(array[k] + " ");
            }
            Console.WriteLine();

        }



    }
}


      


 
