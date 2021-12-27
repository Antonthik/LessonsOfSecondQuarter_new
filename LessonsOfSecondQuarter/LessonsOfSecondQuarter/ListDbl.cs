using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsOfSecondQuarter
{
    class ListDbl : ILinkedList
    {
        private Node nextNode;
        private Node prevNode;
        int count;

        /// <summary>
        /// Добавление элемента
        /// </summary>
        /// <param name="value"></param>
        public void AddNode(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;

            if (prevNode == null)
                prevNode = newNode;
            else
            {
                nextNode.NextNode = newNode;
                newNode.PrevNode = nextNode;
            }
            nextNode = newNode;
            count++;
        }

        /// <summary>
        /// Добавление элемента перед другим элементом
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void AddNodeAfter(Node node, int value)
        {
            if (node is null)
            {
                return;
            }

            Node newNode = new Node();
            newNode.Value = value;

            Node nextItem = node.NextNode;

            node.NextNode = newNode;
            nextItem.PrevNode = newNode;

            newNode.NextNode = nextItem;
            newNode.PrevNode = node;
            count++;
        }

        /// <summary>
        /// Поиск элемента по значению
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public Node FindNode(int searchValue)
        {
            
            Node current = prevNode;

            while (current != null)
            {
                if (current.Value == searchValue)
                    return current;

                current = current.NextNode;
            }

            return null; // если ничего не нашли, то n
        }

        /// <summary>
        /// Количество элементов в списке
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return count;
        }

        /// <summary>
        /// Удаление следующего элемента
        /// </summary>
        /// <param name="node"></param>
        public void RemoveNextItem(Node node)
        {
            if (node.NextNode == null)
                return;

            Node nextItem = node.NextNode;


            RemoveNodeCurrent(nextItem);

        }

        /// <summary>
        /// Удаление элемента по индексу
        /// </summary>
        /// <param name="index"></param>
        public void RemoveNode(int index)
        {
            int currentindex = 0;
            Node current = prevNode;

            while (current!=null)
            {
                if (currentindex== index)
                {
                    break;
                }
                current = current.NextNode;
                currentindex++;
            }

            RemoveNodeCurrent(current);

           // return true;
        }

        private void RemoveNodeCurrent(Node current)
        {
            // если узел не последний
            if (current.NextNode != null)
            {
                current.NextNode.PrevNode = current.PrevNode;
            }
            else
            {
                // если последний, переустанавливаем nextNode
                nextNode = current.PrevNode;
            }

            // если узел не первый
            if (current.PrevNode != null)
            {
                current.PrevNode.NextNode = current.NextNode;
            }
            else
            {
                // если первый, переустанавливаем prevNode
                prevNode = current.NextNode;
            }
            count--;
        }
    }





}

