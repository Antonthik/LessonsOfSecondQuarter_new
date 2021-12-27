using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LessonsOfSecondQuarter
{
    class Program
    {


        static void Main(string[] args)
        {
            List<Interflesson> lessonsInterf = new List<Interflesson>();
            List <Lessons > lessonsClass = new List<Lessons> ();

            string pathDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
            string fileName = "lessons.json";

            lessonsInterf=addLessons(fileName,pathDir);//Формируем список

            lessonsClass = lessonsListIn(pathDir, "lessons.json");//Читаем список из файла


            Console.WriteLine($"Список доступных уроков:");
            foreach (Lessons lesson in lessonsClass)
            {
                Console.WriteLine($"имя: {lesson.NameLesson} описание:{lesson.Discription}");
            }

            Console.WriteLine($"Введите имя урока для запуска:");
            string input = Console.ReadLine();

            foreach (Interflesson lesson in lessonsInterf)
            {
                if (input == lesson.NameLesson)
                {
                    lesson.Demo();
                }                

            }


            List <Interflesson> addLessons(string fileName, string pathDir)
            {
                   List<Interflesson> lessons = new List<Interflesson>
                   {
                        new Lesson1_task1(),
                        new Lesson1_task2(),
                        new Lesson1_task3(),
                        new Lesson2_task1(),
                        new Lesson3_task1(),
                        new Lesson4_task1(),
                        new Lesson4_task2(),
                        new Lesson5_task1(),
                        new Lesson6_task1()
                   };

                    string pathFile = Path.Combine(pathDir, fileName);
                    File.Delete(pathFile); //удаляем файл-список уроков
                    
                    //формируем файл со списком 
                    foreach (Interflesson les in lessons)
                    {
                        Lessons less = new Lessons(les.NameLesson, les.Discription);
                        serial_json(less, fileName, pathDir);
                    }

                return lessons;
            }

            //Серилизация json списка объктов уроков
            static void serial_json(Lessons task, string fileName, string pathDir)
            {
                //string pathDir = @"C:\!test\";
                //string fileName = "tasks.json";
                string pathFile = Path.Combine(pathDir, fileName);

                //if (File.Exists(pathFile)){File.Delete(pathFile);}

                string json = JsonSerializer.Serialize(task);
                File.AppendAllText(pathFile, $"{json} {(char)13}");

            }

            //Читаем задачи,десериализация json
             List<Lessons> lessonsListIn(string pathDir, string fileName)
            {
                string pathFile = Path.Combine(pathDir, fileName);

                if (File.Exists(pathFile))
                {
                    List<Lessons> less = new List<Lessons>();//создаем список объектов уроков

                    string[] jsons = File.ReadAllLines(pathFile);//создаем массив строк
                    foreach (string v in jsons)
                    {
                        Lessons les = JsonSerializer.Deserialize<Lessons>(v);//создаеи объект урока из строки
                        less.Add(les);
                    }

                    return less;
                }
                else
                {
                    return null;
                }
            }



        }


        
        

    }
}
