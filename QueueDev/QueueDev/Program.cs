using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DtsLib;
using static System.Console;

namespace QueueDev
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayQueue<int> queue = new ArrayQueue<int>(10);
            WriteLine(queue);

            queue.Enqueue(5);
            WriteLine(queue);

            queue.Enqueue(13);
            WriteLine(queue);

            WriteLine(queue.Dequeue());
            WriteLine(queue);

            queue.Enqueue(-3);
            queue.Enqueue(25);
            WriteLine(queue.Head());
            WriteLine(queue);

            WriteLine(queue.Dequeue());
            WriteLine(queue);

            //stack.Dequeue();
            //stack.Dequeue();
            //stack.Dequeue();

            queue.Enqueue(2);
            queue.Enqueue(25);
            queue.Enqueue(57);
            WriteLine(queue);

            queue.Enqueue(-87);
            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Enqueue(1);
            WriteLine(queue);
        }
    }
}
