using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionLinkedList
{
    public class LinkedListNode
    {
        public LinkedListNode(int value)
        {
            Value = value;
        }
        public LinkedListNode Next { get; set; }

        public int Value { get; set; }
    }
}
