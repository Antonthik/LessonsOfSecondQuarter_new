using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Проход дерева с использованием очереди и стэка
/// </summary>
namespace LessonsOfSecondQuarter
{
    class Lesson5_task1 : Interflesson
    {
        public string NameLesson => "BFS_DFS";

        public string Discription => "Поиск в глубину и ширину по дереву";

        public void Demo()
        {
            TreeBinary BinarTree = new TreeBinary();
            BinarTree.AddItem(10);
            BinarTree.AddItem(100);
            BinarTree.AddItem(1);
            BinarTree.AddItem(4);
            BinarTree.AddItem(50);
            BinarTree.AddItem(0);
            BinarTree.AddItem(19);
            BinarTree.AddItem(45);
            BinarTree.AddItem(17);

            TreeNode root = BinarTree.GetRoot();
            var queueTree = new Queue<TreeNode>();
            queueTree.Enqueue(root);

            
            var stackTree = new Stack<TreeNode>();
            stackTree.Push(root);

            BFSGo(root, queueTree);

            Console.WriteLine("");
            DFSGo(root, stackTree);
            //var queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //var qItemOne = queue.Dequeue();
            //var qItemTwo = queue.Dequeue();
            //Console.WriteLine($"{qItemOne},  {qItemTwo} ");

            //var stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //var sItemOne = stack.Pop();
            //var sItemTwo = stack.Pop();
            //Console.WriteLine($"{sItemOne},  {sItemTwo} ");



        }
        /// <summary>
        /// Проход по дереву с использование очереди
        /// </summary>
        /// <param name="startNode"></param>
        /// <param name="queueTree"></param>
        private void BFSGo(TreeNode startNode, Queue<TreeNode> queueTree)
        {
            if (startNode == null ) return;    
            
                foreach (TreeNode el in queueTree)
                {
                    
                    if (el != null)
                    {
                        startNode = queueTree.Dequeue();
                        Console.WriteLine(startNode.Value);
                        
                        if (startNode.RightChild!=null) queueTree.Enqueue(startNode.RightChild);
                        if (startNode.LeftChild != null) queueTree.Enqueue(startNode.LeftChild);

                    BFSGo(startNode, queueTree);

                        if ( queueTree.Count == 0)
                        {
                            startNode = null;
                            break;
                        }
                    }
                  
                    
                }            
        }
        /// <summary>
        /// Проход по дереву с использование стека
        /// </summary>
        /// <param name="startNode"></param>
        /// <param name="stackTree"></param>
        private void DFSGo(TreeNode startNode, Stack<TreeNode> stackTree)
        {
            if (startNode == null) return;

            foreach (TreeNode el in stackTree)
            {

                if (el != null)
                {
                    startNode = stackTree.Pop();
                    Console.WriteLine(startNode.Value);
                    if (startNode.LeftChild != null) stackTree.Push(startNode.LeftChild);
                    if (startNode.RightChild != null) stackTree.Push(startNode.RightChild);


                    DFSGo(startNode, stackTree);

                    if (stackTree.Count == 0)
                    {
                        startNode = null;
                        break;
                    }
                }


            }
        }





    }
}
