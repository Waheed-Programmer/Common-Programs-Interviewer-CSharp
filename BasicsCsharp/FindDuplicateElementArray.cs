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

        }
    }
}
