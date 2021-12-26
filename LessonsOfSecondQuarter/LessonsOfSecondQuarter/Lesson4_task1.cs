using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    class Lesson4_task1 : Interflesson
    {
        public string NameLesson => "HashSet";

        public string Discription => "Применение HashSet и проверка производительности";

        public void Demo()
        {
            int[] arr = new int[100000];
            //Random rnd = new Random();
            var hashSet = new HashSet<int>();
            //Генерация массива координат
            for (int i = 0; i < arr.Length; i++)
            {
                //arr[i] = rnd.Next(0, 100);
                //Console.WriteLine($"{arr[i]}");
                hashSet.Add(i);
                arr[i] = i;
            }
            //Замер производительности hashSet
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            foreach (int t in hashSet)
            {
                Console.WriteLine($"{t}");
            }
            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;

            //Замер производительности массива
            stopWatch.Start();
            foreach (int t in arr)
            {
                Console.WriteLine($"{t}");
            }
            stopWatch.Stop();
            TimeSpan ts2 = stopWatch.Elapsed;

            Console.WriteLine($"Время исполнения с использованием hashSet {ts1}");
            Console.WriteLine($"Время исполнения с использованием массива {ts2}");

        }
    }
}
