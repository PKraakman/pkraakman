
using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    class Stack
    {
        private List<int> _stack;

        public Stack()
        {
            _stack = new List<int>();
        }

        public void Push(int number)
        {
            _stack.Add(number);
        }
        public int Pop()
        {
            var lastitem = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return lastitem;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Clear();

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
