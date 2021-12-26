using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    /// <summary>
    /// Расчет числа Фибонначи
    /// </summary>
    class Lesson1_task3 : Interflesson
    {
        public string NameLesson => "numberFib";

        public string Discription => "Расчет числа Фибонначи по номеру";

        public void Demo()
        {
            Console.WriteLine("Введите номер числа Фибоначчи.");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            if (num <= 0)
            {
                num = 1;
            }

            numberFib(num);

        }

        /// <summary>
        /// Нахождения числа Фибоначчи двумя способами(цмклом и рекурсией)
        /// 
        /// </summary>
        private void numberFib(int num)
        {
            


            // используем класс FibNumber для расчета числа
            FibNumber fib = new FibNumber(num);
            fib.printFib();


        }

    }
}
