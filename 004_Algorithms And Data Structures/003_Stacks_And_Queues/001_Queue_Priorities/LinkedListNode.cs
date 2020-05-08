using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Queue_Priorities
{
    class LinkedListNode<T>
    {
        public LinkedListNode(T value, T priority)
        {
            Value = value;
            Priority = priority;
        }

        public T Value
        {
            get;
            set;
        }

        public T Priority
        {
            get;
            set;
        }

        public LinkedListNode<T> Next
        {
            get;
            set;
        }

        public LinkedListNode<T> Previous
        {
            get;
            set;
        }
    }
}
