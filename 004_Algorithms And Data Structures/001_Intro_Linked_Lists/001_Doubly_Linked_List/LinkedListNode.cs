﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Doubly_Linked_List
{
    class LinkedListNode <T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value
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
