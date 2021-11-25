using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2b
{
    class Program
    {
        // Задание выполнил Белянкин Виктор Леонидович,  31 год, г. Томск
        // Задача №2b Реализовать функцию возведения числа a в степень b, рекурсивно

        static void Main(string[] args)
        {
            double fixedNumber;
            double number = fixedNumber = 15;
            double result = Exponentiation(ref number,fixedNumber,  3);
            Console.WriteLine(result);
        }

        static double Exponentiation(ref double number, double fixedNumber, double degree, int i = 1)
        {
            
            number = number * fixedNumber;
            i++;

            if (i != degree)
            {
                Exponentiation(ref number,fixedNumber, degree, i);
            }

            return number;
        }
    }
}
