using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DtsLib;

namespace StackDev
{
    class Program
    {
        static void Main(string[] args)
        {
            IStack<int> stack = new ArrayStack<int>(5);
            
            stack.Push(5);
            stack.Push(13);
            Console.WriteLine(stack.Pop());
            stack.Push(-3);
            stack.Push(25);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
        }
    }
}
