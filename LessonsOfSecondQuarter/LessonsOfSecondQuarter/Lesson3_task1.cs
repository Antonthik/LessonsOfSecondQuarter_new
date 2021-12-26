using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    class Lesson3_task1 : Interflesson
    {
        public string NameLesson => "TestStopwatch";

        public string Discription => "Измерение производительности при помощи Stopwatch";

        public void Demo()
        {
            double[] arr = new double[100000000];
            Random rnd = new Random();


            Console.WriteLine($"Массив начало заполнения");
            //Генерация массива координат
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0,100);
                //Console.WriteLine($"{arr[i]}");
            }
            Console.WriteLine($"Массив заполнен");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //Алгоритм расчета растояния между точками с использованием структуры
            PointStruct pointOne = new PointStruct();
            PointStruct pointTwo = new PointStruct();
            for (int i = 0; i < arr.Length-4; i++)
            {
                pointOne.x = arr[i];
                pointOne.y = arr[i + 1];
                pointTwo.x = arr[i + 2];
                pointTwo.y = arr[i + 3];
                double dist = PointDistance(pointOne, pointTwo);
                //Console.WriteLine($"{dist}");
            }
            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;
            

            
            stopWatch.Start();
            //Алгоритм расчета растояния между точками с использованием класса
            PointClass pointOneC = new PointClass();
            PointClass pointTwoC = new PointClass();
            for (int i = 0; i < arr.Length - 4; i++)
            {
                pointOneC.x = arr[i];
                pointOneC.y = arr[i + 1];
                pointTwoC.x = arr[i + 2];
                pointTwoC.y = arr[i + 3];
                double dist = PointDistanceClass(pointOneC, pointTwoC);
                //Console.WriteLine($"{dist}");
            }
            stopWatch.Stop();
            TimeSpan ts2 = stopWatch.Elapsed;

            Console.WriteLine($"Время исполнения с использованием структуры {ts1}");
            Console.WriteLine($"Время исполнения с использованием класса {ts2}");


        }


        /// <summary>
        /// Точка координаты которой представленны
        /// в виде типа данных - структура
        /// </summary>
        public struct PointStruct
        {
            public double x;
            public double y;
        }

        public class PointClass
        {
            public double x;
            public double y;
        }

        /// <summary>
        /// Вычисление расстояния
        /// </summary>
        /// <param name="pointOne"></param>
        /// <param name="pointTwo"></param>
        /// <returns></returns>
        public static double PointDistance(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.x - pointTwo.x;
            double y = pointOne.y - pointTwo.y;
            return Math.Sqrt((x * x) + (y * y));
        }

        public static double PointDistanceClass(PointClass pointOne, PointClass pointTwo)
        {
            double x = pointOne.x - pointTwo.x;
            double y = pointOne.y - pointTwo.y;
            return Math.Sqrt((x * x) + (y * y));
        }



    }
}
