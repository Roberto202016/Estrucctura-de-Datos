using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtsLib
{
    class ArrayQueue<T> : IQueue<T>
    {
        private T[] data;
        private int index;
        //private readonly int initialCapacity;

        public int Capacity { get; private set; }
        public int Size => index + 1;

        public bool Empty => index == -1;

        public ArrayQueue(int capacity)
        {
            data = new T[capacity];
            //initialCapacity = capacity;
            Capacity = capacity;
            index = -1;
        }

        public void Enqueue(T item)
        {
            data[index + 1] = item;
            index++;
        }

        public T Dequeue()
        {
            if (Empty) { throw new InvalidOperationException(); }

            T aux = data[0];
            for (int i = 0; i < index; i++)
            {
                data[i] = data[i + 1];
            }

            data[index] = default;
            index--;
            return aux;
        }

        public T Head()
        {
            if (Empty) { throw new InvalidOperationException(); }
            return data[0];
        }

        public T Tail()
        {
            if (Empty) { throw new InvalidOperationException(); }
            return data[index];
        }

        public override string ToString()
        {
            string str = $"C:{Capacity}, S:{Size}, E:{Empty}";

            str += "\n[";
            for (int i = 0; i <= index; ++i)
            {
                str += $" {data[i]}";
            }
            str += " ]\n";

            return str;
        }
    }
}
