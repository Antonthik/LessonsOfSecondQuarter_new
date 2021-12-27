using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    class FibNumber     

    {
        int NumberForFib { get; set; }//номер числа, ряд начинается с 1 (1,1,2,3...)
        bool Recurs { get; set; }

        public FibNumber(int numberForFib,bool recurs=true)
        {
            NumberForFib = numberForFib;
            Recurs = recurs;
        }

        public void printFib()
        {
            if (this.Recurs == true)
            {

                if (this.NumberForFib == 1)
                {
                    Console.WriteLine($"Число Фибоначчи для {this.NumberForFib} = {"1"}");
                }
                else
                {
                    Console.WriteLine($"Число Фибоначчи для {this.NumberForFib} = {GetFibRec(0, 1, this.NumberForFib-2)} - рекурсия");
                    Console.WriteLine($"Число Фибоначчи для {this.NumberForFib} = {GetFibCikl(0, 1, this.NumberForFib-2)} - циклом");
                }

            }
            
        }

        /// <summary>
        /// Метод нахождения числа Фибоначчи - используем рекурсивный вызов
        /// Задаем первые два числа Фибоначчи для расчетого следующего
        /// count - убывающий счетчик итераций,выходим при достижении нуля.
        /// Устанавливаем для a=0; b=1;count - номер числа Фибоначчи
        /// </summary>

        public int GetFibRec(int a, int b, int count)
        {

            // Выход из рекурсионного вызова
            if (count == 0)
            {
                return a + b;
            }

            int c = b;
            b = a + b; // расчет нового значения
            a = c;

            //передаем новое значение и предыдущее - счетчик уменьшаем
            int n = GetFibRec(a, b, count - 1); // Вызываем метод из самого себя

            //Console.WriteLine(n);
            return n;

        }

        /// <summary>
        /// Метод нахождения числа Фибоначчи - используем цикл
        /// </summary>

        public static int GetFibCikl(int a, int b, int count)
        {
            int n=1;

            for (int i = 0; i < count; i++)
            {
                int c = b;
                b = a + b; // расчет нового значения
                a = c;

                n = a + b;
            }



            
            return n;

        }
    }
}
