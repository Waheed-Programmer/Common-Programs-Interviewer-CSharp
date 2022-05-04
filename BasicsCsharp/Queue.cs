using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCsharp
{
    internal class Queue
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(12);
            q.Enqueue(15);
            q.Enqueue(19);
            q.Enqueue(14);

            Console.WriteLine("The List of Queue is " +q.Count());

            q.Dequeue();
            q.Dequeue();

            Console.WriteLine("After Deque the List of Queue is " + q.Count());

        }
    }
}
