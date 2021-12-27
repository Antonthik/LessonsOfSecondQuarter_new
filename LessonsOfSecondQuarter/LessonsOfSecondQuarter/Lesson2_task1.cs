using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    /// <summary>
    /// Реализация класса спискa (Двусвязный список)
    /// </summary>
    class Lesson2_task1 : Interflesson
    {
        public string NameLesson => "LinkedList";

        public string Discription => "Реализация класса спискa (Двусвязный список)";

        public void Demo()
        {
            ListDbl MyList = new ListDbl();
            MyList.AddNode(6);//добавили элемент списка
            MyList.AddNode(10);
            MyList.AddNode(25);


            Node findeNode = MyList.FindNode(6);//поиск по значению
            int countList = MyList.GetCount();//количество элементов списка
            MyList.AddNodeAfter(MyList.FindNode(6), 4);
            MyList.RemoveNextItem(findeNode);//удаление следующего элемента
            MyList.RemoveNode(1);




        }


    }
}
