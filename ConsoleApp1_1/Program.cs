using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("i = "); // вывод i=
            double i = double.Parse(Console.ReadLine()); // преобразование строки в число и считывание x с клавиатуры

            Console.WriteLine(i); // вывод значения x
            if (i == -1) // проверка на недопустимое значение
            {
                Console.WriteLine("Функция не определена"); // вывод сообщения об ошибке
            }
            else
            {
                double y = 1 / Math.Pow(1 + i, 2); // вычисление значения функции
                Console.WriteLine("y({0:f2}) = {1:f2}", i, y); // вывод результата 
            }
        }

        }
    }
}
