using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    class Lesson1_task2 : Interflesson

    {
        public string NameLesson => "Analisys";

        public string Discription => "Анализ сложности алгоритма";

        public void Demo()
        {
            outt();
        }

        /// <summary>
        /// Данный алгоритм имеет три вложенных цикла, что дает сложность N(1)+N(i*j*(k*4)),
        /// где в цикле k вложено четыре операции, что приводит к увеличению. В тоже время элементарные
        /// операции вне циклов можно исключить из расчета, при больших размерностях циклов.
        /// </summary>
         private void outt()
        {
            //public static int StrangeSum(int[] inputArray)
            //{
            //    int sum = 0;  //N(1)
            //    for (int i = 0; i < inputArray.Length; i++) //N(i)
            //    {
            //        for (int j = 0; j < inputArray.Length; j++)//N(j)
            //        {
            //            for (int k = 0; k < inputArray.Length; k++)//N(k)
            //            {
            //                int y = 0;//N(1)
            //
            //                if (j != 0)//N(1)
            //                {
            //                    y = k / j;//N(1)
            //                }
            //
            //                sum += inputArray[i] + i + k + j + y;//N(1)
            //            }
            //        }
            //    }
            //
            //    return sum;
            //}

            Console.WriteLine("Сложность N(1)+N(i*j*(k*4))");

        }

    }
}
