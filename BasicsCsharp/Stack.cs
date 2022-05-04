﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCsharp
{
    internal class Stack
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            // add element in stack using push method
            myStack.Push("Greed");
            myStack.Push("Is");
            myStack.Push("Curse");
            myStack.Push("Welcome");
            myStack.Push("To");
            myStack.Push("Stack");

            // Accessing element through foreach loop
            Console.WriteLine("Total Elements Present in Stack is : {0}", +myStack.Count());

            // Remove element in stack using pop method

            myStack.Pop();
            myStack.Pop();

            //After Pop method 

            Console.WriteLine("After Pop the total Elements Present in Stack is : {0}", +myStack.Count());

            //Remove all element inn stack is 

            myStack.Clear();

            Console.WriteLine("After Clear mehtod the total Elements Present in Stack is : {0}", +myStack.Count());


        }
    }
}
