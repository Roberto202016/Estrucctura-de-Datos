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

        public int Size => index + 1;

        public bool Empty => index == -1;

        public ArrayStack(int size)
        {
            data = new T[size];
            index = -1;
        }

        public void Push(T item)
        {
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
    }
}
