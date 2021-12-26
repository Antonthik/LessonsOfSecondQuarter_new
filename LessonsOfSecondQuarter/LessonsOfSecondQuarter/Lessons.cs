using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    class Lessons 
    {
        public string NameLesson { get;}
        public string Discription { get; }

        public Lessons(string nameLesson, string discription)
        {
            NameLesson = nameLesson;
            Discription = discription;
        }



    }
}
