using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCsharp
{
    internal class FindDuplicateElementArray
    {
        static void Main(string[] args)
        {
            //Find All duplicate Element in Array

            int[] arr = { 1, 2, 3, 4, 5, 6, 6, 3, };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
            //Find string duplicates using toCharArray() method
            string str = "aaetioommrl";
            char[] ch = str.ToCharArray();
            for (int w = 0; w < ch.Length; w++)
            {
                for (int y = w + 1; y < ch.Length; y++)
                {
                    if (ch[w] == ch[y])
                    {
                        Console.WriteLine(ch[w]);
                    }
                }
            }

            Console.WriteLine("========================>");

            //Combine two array with out duplicate elements

            string[] animals = { "Cat", "Alligator", "Fox", "Donkey", "Cat" };
            string[] birds = { "Sparrow", "Peacock", "Dove", "Crow" };

            var all = animals.Union(birds).ToArray();
            Array.ForEach(all, s => Console.WriteLine(s));

            Console.WriteLine("==============================>");


            //using linq to find value max. min , sum or averge

            int[] nums = new int[5] { 10, 15, 16, 8, 6 };

            Console.WriteLine(nums.Reverse());
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Sum());
            Console.WriteLine(nums.Average());
        }
    }
}
