using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    class TreeBinary
    {

        private TreeNode _head;
        private int _count;
        public void AddItem(int value)       {
   

            //Случай 1: Если дерево пустое, просто создаем корневой узел.
            if (_head == null)
            {
                _head = new TreeNode();
                _head.Value = value;
            }
            //Случай 2: Дерево не пустое => 
            //ищем правильное место для вставки.
            else
            {
                AddTo(_head, value);
            }

            _count++;
        }

        private void AddTo(TreeNode node, int value)
        {
            //Случай 1: Вставляемое значение меньше значения узла
            if (value < node.Value)
            {
                //Если нет левого поддерева, добавляем значение в левого ребенка,
                if (node.LeftChild == null)
                {
                    node.LeftChild = new TreeNode();
                    node.LeftChild.Value = value;
                }
                else
                {
                    //в противном случае повторяем для левого поддерева.
                    AddTo(node.LeftChild, value);
                }
            }
            //Случай 2: Вставляемое значение больше или равно значению узла.
            else
            {
                //Если нет правого поддерева, добавляем значение в правого ребенка,
                if (node.RightChild == null)
                {
                    node.RightChild = new TreeNode();
                    node.RightChild.Value = value;
                }
                else
                {
                    //в противном случае повторяем для правого поддерева.
                    AddTo(node.RightChild, value);
                }
            }
        }
        /// <summary>
        /// Поиск узла по значению
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public TreeNode GetNodeByValue(int value, out TreeNode parent)
        {
            //Попробуем найти значение в дереве.
            TreeNode current = _head;
            parent = null;

            //До тех пор, пока не нашли...
            while (current != null)
            {
               //int result = current.CompareTo(value);

                if (current.Value > value)
                {
                    //Если искомое значение меньше, идем налево.
                    parent = current;
                    current = current.LeftChild;
                }
                else if (current.Value < value)
                {
                    //Если искомое значение больше, идем направо.
                    parent = current;
                    current = current.RightChild;
                }
                else
                {
                    //Если равны, то останавливаемся
                    break;
                }
            }

            return current;
        }

        public TreeNode GetRoot()
        {
            return _head;
        }

        public void PrintTree()
        {
            // parent = null;
            TreeNode current = _head;

            //До тех пор, пока не нашли...
            while (current != null)
            {
                
            }
        }

        /// <summary>
        /// Удаление узла
        /// </summary>
        /// <param name="value"></param>
        public void RemoveItem(int value)
        {
            TreeNode current, parent;

            // Находим удаляемый узел.
            current = GetNodeByValue(value, out parent);


            if (current != null)
            {
                _count--;

                //Случай 1: Если нет детей справа,
                //левый ребенок встает на место удаляемого.
                if (current.RightChild == null)
                {
                    if (parent == null)
                    {
                        _head = current.LeftChild;
                    }
                    else
                    {
                      
                        if (parent.Value > value)
                        {
                            //Если значение родителя больше текущего,
                            //левый ребенок текущего узла становится левым ребенком родителя.
                            parent.LeftChild = current.LeftChild;
                        }
                        else if (parent.Value < value)
                        {
                            //Если значение родителя меньше текущего,
                            // левый ребенок текущего узла становится правым ребенком родителя.
                            parent.RightChild = current.LeftChild;
                        }
                    }
                }
                //Случай 2: Если у правого ребенка нет детей слева
                //то он занимает место удаляемого узла.
                else if (current.RightChild.LeftChild == null)
                {
                    current.RightChild.LeftChild = current.LeftChild;
                    if (parent == null)
                    {
                        _head = current.RightChild;
                    }
                    else
                    {
                        //int result = parent.CompareTo(current.Value);
                        if (parent.Value > value)
                        {
                            //Если значение родителя больше текущего,
                            //правый ребенок текущего узла становится левым ребенком родителя.
                            parent.LeftChild = current.RightChild;
                        }
                        else if (parent.Value < value)
                        {
                            //Если значение родителя меньше текущего,
                            // правый ребенок текущего узла становится правым ребенком родителя.
                            parent.RightChild = current.RightChild;
                        }
                    }
                }
                //Случай 3: Если у правого ребенка есть дети слева,
                //крайний левый ребенок 
                //из правого поддерева заменяет удаляемый узел.
                else
                {
                    //Найдем крайний левый узел.
                    TreeNode leftmost = current.RightChild.LeftChild;
                    TreeNode leftmostParent = current.RightChild;
                    while (leftmost.LeftChild != null)
                    {
                        leftmostParent = leftmost; leftmost = leftmost.LeftChild;
                    }
                    //Левое поддерево родителя становится правым поддеревом
                    //крайнего левого узла.
                    leftmostParent.LeftChild = leftmost.RightChild;
                    //Левый и правый ребенок текущего узла становится левым
                    //и правым ребенком крайнего левого.
                    leftmost.LeftChild = current.LeftChild;
                    leftmost.RightChild = current.RightChild;
                    if (parent == null)
                    {
                        _head = leftmost;
                    }
                    else
                    {
                        //int result = parent.CompareTo(current.Value);
                        if (parent.Value > value)
                        {
                            //Если значение родителя больше текущего,
                            //крайний левый узел становится левым ребенком родителя.
                            parent.LeftChild = leftmost;
                        }
                        else if (parent.Value < value)
                        {
                            //Если значение родителя меньше текущего,
                            //крайний левый узел становится правым ребенком родителя.
                            parent.RightChild = leftmost;
                        }
                    }
                }

                //return true;


            }
        }
    }
}
