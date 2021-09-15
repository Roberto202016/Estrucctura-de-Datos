using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DtsLib;

using static System.Console;

namespace StackDev
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> stack = new ArrayStack<int>(2);
            WriteLine(stack);
            
            stack.Push(5);
            WriteLine(stack);

            stack.Push(13);
            WriteLine(stack);

            WriteLine(stack.Pop());
            WriteLine(stack);

            stack.Push(-3);
            stack.Push(25);
            WriteLine(stack.Peek());
            WriteLine(stack);

            WriteLine(stack.Pop());
            WriteLine(stack);

            //stack.Pop();
            //stack.Pop();
            //stack.Pop();

            stack.Push(2);
            stack.Push(25);
            stack.Push(57);
            WriteLine(stack);

            stack.Push(-87);
            stack.Push(5);
            stack.Push(3);
            stack.Push(1);
            WriteLine(stack);
        }
    }
}
