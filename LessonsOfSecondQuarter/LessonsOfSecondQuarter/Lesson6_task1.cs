using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    /// <summary>
    /// "Создание списка уроков
    /// </summary>

    class Lesson6_task1 : Interflesson
    {
        public string NameLesson => "CreateListLessons";

        public string Discription => "Создание списка уроков";

        public void Demo()
        {
            List<Interflesson> lessons = new List<Interflesson>()
            {
                new  Lesson1_task1(),
                new  Lesson1_task2(),
                new  Lesson1_task3(),
                new  Lesson2_task1(),
                new  Lesson3_task1(),
                new  Lesson4_task1(),
                new  Lesson4_task2(),
                new  Lesson5_task1()
            };
            string pathDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
            string fileName = "lessons.json";
            string pathFile = Path.Combine(pathDir, fileName);

            //string pathDir = @"C:\!UserFolder\";
            //createFolder(pathDir);
            if (File.Exists(pathFile)==false)
            {
                File.Delete(pathFile); //удаляем файл-список уроков
                //формируем файл со списком 
                foreach (Interflesson les in lessons)
                {
                    Lessons less = new Lessons(les.NameLesson, les.Discription);
                    serial_json(less, fileName, pathDir);
                }
            }
            else
            {
                lessonsListIn(pathDir, "lessons.json");//Читаем список
            }


          

        }

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
        static List<Lessons> lessonsListIn(string pathDir, string fileName)
        {
            string pathFile = Path.Combine(pathDir, fileName);

            if (File.Exists(pathFile))
            {
                List <Lessons> less= new List<Lessons>();//создаем список объектов уроков

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
