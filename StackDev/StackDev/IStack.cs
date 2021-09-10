using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtsLib
{
    interface IStack<T>
    {
        int Size { get; }
        bool Empty { get; }

        void Push(T item);
        T Pop();
        T Peek();
    }
}
