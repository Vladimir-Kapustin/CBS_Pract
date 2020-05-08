using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Queue_Priorities
{
    public class Deque<T>       // the queue based on my custom LinkedList
    {
        LinkedList<T> _items = new LinkedList<T>();

        // number of elements in Deque - maybe not needed 
        int _size = 0;

        // Head pointer
        int _head = 0;  // initial value

        // Tail pointer
        int _tail = 0; // initial value

        public void EnqueueFirst(T value, T priority)
        {

        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
