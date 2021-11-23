using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
         
            {
                Console.Title = "Домашнее задание №1, Белянкин Виктор Леонидович, 31 год, г.Томск";

                Tasks.Menu_start.Menu();
                string m = Console.ReadLine();

                do
                {

                    switch (m)
                    {
                        case "1":
                            Tasks.Tasks.Task_1();
                            break;
                        case "2":
                            Tasks.Tasks.Task_2();
                            break;
                        case "3":
                            Tasks.Tasks.Task_3();
                            break;
                        case "4":
                            Tasks.Tasks.Task_4();
                            break;
                        case "5":
                            Tasks.Tasks.Task_5();
                            break;


                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                } while (m != "0");

            }
        }
    }
    
}
