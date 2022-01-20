using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            
            if(stack.Count > 0)
                stack.Pop();

            stack.Push(1);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine("The top value {0} was removed from the stack", stack.Pop());
                Console.WriteLine("Current stack count is {0}", stack.Count);
            }

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Stack<int> myStack = new Stack<int>();

            foreach(int number in numbers)
            {
                myStack.Push(number);
            }

            while(myStack.Count > 0)
                Console.Write("{0} ", myStack.Pop());

            Console.ReadKey();
        }
    }
}
