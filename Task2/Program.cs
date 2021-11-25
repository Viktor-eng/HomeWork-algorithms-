using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {    
        // Задание выполнил Белянкин Виктор Леонидович,  31 год, г. Томск
        // Задача №2а Реализовать функцию возведения числа a в степень b, без рекурсии
        static void Main(string[] args)
        {
            Exponentiation(15, 3);
        }

        static void Exponentiation(double number, double degree)     
        {
           number = Math.Pow(number,degree);
           Console.WriteLine(number);
        }
    }
}
