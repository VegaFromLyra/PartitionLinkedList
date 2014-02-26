using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given a linked list and a value, partition it such that
// the elements less than the value come before the elements
// greater than the value
namespace PartitionLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode node1 = new LinkedListNode(2);
            LinkedListNode node2 = new LinkedListNode(5);
            LinkedListNode node3 = new LinkedListNode(3);
            LinkedListNode node4 = new LinkedListNode(4);

            int x = 4;

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            Partition(node1, x);
        }

        static void Partition(LinkedListNode node, int x)
        {
            LinkedListNode beforeStart = null;
            LinkedListNode beforeEnd = null;

            LinkedListNode afterStart = null;
            LinkedListNode afterEnd = null;

            while (node != null)
            {
                LinkedListNode next = node.Next;
                node.Next = null;

                if (node.Value < x)
                {
                    if (beforeStart == null)
                    {
                        beforeStart = node;
                        beforeEnd = node;
                    }
                    else
                    {
                        beforeEnd.Next = node;
                        beforeEnd = node;
                    }
                }
                else
                {
                    if (afterStart == null)
                    {
                        afterStart = node;
                        afterEnd = node;
                    }
                    else
                    {
                        afterEnd.Next = node;
                        afterEnd = node;
                    }
                }

                node = next;
            }

            if (beforeStart == null)
            {
                beforeStart = afterStart;
            }
            else
            {
                LinkedListNode current = beforeStart;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = afterStart;
            }

            Console.WriteLine("Partitioned list is");

            LinkedListNode print = beforeStart;

            while (print != null)
            {
                Console.Write(print.Value + " ");
                print = print.Next;
            }
        }
    }
}
