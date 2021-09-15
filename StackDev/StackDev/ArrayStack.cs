using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtsLib
{
    class ArrayStack<T> : IStack<T>
    {
        private T[] data;
        private int index;
        private readonly int initialCapacity;

        public int Capacity { get; private set; }
        public int Size => index + 1;

        public bool Empty => index == -1;

        public ArrayStack(int capacity)
        {
            data = new T[capacity];
            initialCapacity = capacity;
            Capacity = capacity;
            index = -1;
        }

        public void Push(T item)
        {
            if (Size == Capacity)
            {
                Array.Resize<T>(ref data, Capacity * 2);
                Capacity *= 2;

                /*
                T[] newData = new T[Capacity * 2];
                Array.Copy(data, newData, Capacity);
                data = newData;
                */
            }

            data[index + 1] = item;
            index++;
        }

        public T Pop()
        {
            if (Empty)
            {
                throw new IndexOutOfRangeException("index");
            }

            index--;
            return data[index + 1];
        }

        public T Peek() => data[index];

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
