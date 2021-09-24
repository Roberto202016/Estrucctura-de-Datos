using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtsLib
{
    interface IQueue<T>
    {
        int Size { get; }
        bool Empty { get; }

        void Enqueue(T item);
        T Dequeue();
        T Head();
        T Tail();
    }
}
