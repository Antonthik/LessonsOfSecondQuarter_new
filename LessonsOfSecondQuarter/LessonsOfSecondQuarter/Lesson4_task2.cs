using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    
    class Lesson4_task2 : Interflesson
    {
        public string NameLesson => "Tree";

        public string Discription => "Применение дерева";

        public void Demo()
        {
            TreeBinary BinarTree = new TreeBinary();
            BinarTree.AddItem(20);
            BinarTree.AddItem(2);
            BinarTree.AddItem(100);
            BinarTree.AddItem(5);
            BinarTree.AddItem(1);

            TreeNode findeNode = BinarTree.GetNodeByValue(100, out TreeNode parent);
            BinarTree.RemoveItem(20);
            TreeNode root = BinarTree.GetRoot();

        }

      
    }
}
