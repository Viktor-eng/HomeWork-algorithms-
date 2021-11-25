using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2c
{
    class Program
    {
        // Задание выполнил Белянкин Виктор Леонидович,  31 год, г. Томск
        // Задача №2с Реализовать функцию возведения числа a в степень b, *рекурсивно, проверив степень на четность
        static void Main(string[] args)
        {
            double fixedNumber;
            double number = fixedNumber = 15;
            double degree = 2;
            ParityCheck(ref number, fixedNumber, degree);
            
        }

        static void ParityCheck (ref double number, double fixedNumber, double degree, int i = 1)
        {
            double result = Exponentiation(ref number, fixedNumber, degree);
            
            Console.WriteLine(result);

            if (degree % 2 !=0)
            {
                Console.WriteLine("Степень нечетная");
            }
            
            if (degree%2 ==0)
            {
                Console.WriteLine("Степень четная");
            }
        }

        static double Exponentiation(ref double number, double fixedNumber, double degree, int i = 1)          
        {

            number = number * fixedNumber;
            i++;

            if (i != degree)
            {
                Exponentiation(ref number, fixedNumber, degree, i);
            }

            return number;
        }
    }
}
