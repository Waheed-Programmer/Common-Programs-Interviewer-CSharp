using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCsharp
{
    internal class RemoveDuplicateArrayElement
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 5, 4, 6 };
            int[] dist = arr.Distinct().ToArray();
            Array.ForEach(dist, v => Console.WriteLine(v));
            // Remove String Element in array
            string[] str = { "cat", "dog", "cat", "animal", "parrort", "dog" };
            string[]com= str.Distinct().ToArray();
            Array.ForEach(com, vi => Console.WriteLine(vi));
        }
    }
}
