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

            for (i = 0; number > 1; i++)
            {
                number = number / 2;

                if (number % 2 != 0)
                {
                    number = Math.Floor(number);
                }
            }

            double[] array = new double[i];

            for (int j = 0; fixNumber > 1; j++)
            {
                
                fixNumber = fixNumber / 2;

                for (int k = 0; k < array.Length; k++)
                {
                    Console.WriteLine(array[i] + " ");
                }
            }



            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[i] + " ");
            }


        }



    }
}


      


 
