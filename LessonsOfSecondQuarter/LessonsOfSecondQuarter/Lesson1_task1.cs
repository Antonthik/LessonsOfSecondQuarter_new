using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    class Lesson1_task1 : Interflesson
    {
        public string NameLesson => "simplNumber";

        public string Discription => "Нахождение простых чисел";

        public void Demo()
        {
            Console.WriteLine("Введите целое число");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            simplNumder(number);
        }

        private void simplNumder(int number)
        {
            

            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }

                i++;

            }

            if (d == 0)
            {
                Console.WriteLine($"{number} - простое");
            }
            else
            {
                Console.WriteLine($"{number} - не простое");
            }


        }

    }
}
