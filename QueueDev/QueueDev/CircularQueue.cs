using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtsLib
{
    class CircularQueue<T> : IQueue<T>
    {
        private T[] data;
        private int t;
        private int h;

        public int Capacity { get; }
        public int Size { get; private set; }

        public bool Empty => Size == 0;

        public CircularQueue(int capacity)
        {
            data = new T[capacity];
            Capacity = capacity;
            Size = 0;
            h = 0;
            t = 0;
        }

        public void Enqueue(T item)
        {
            if (Size == Capacity) { throw new InvalidOperationException(); }

            
        }

        public T Dequeue()
        {
            throw new NotImplementedException();
        }

        public T Head()
        {
            if (Empty) { throw new InvalidOperationException(); }
            return data[h];
        }

        public T Tail()
        {
            if (Empty) { throw new InvalidOperationException(); }
            return data[t];
        }
    }
}
