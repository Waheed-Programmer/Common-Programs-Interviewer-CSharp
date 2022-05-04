using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCsharp
{
    internal class FindSecondLargestNumberArray
    {
        static void Main(string[] args)
        {
            int max1, max2;
            int[] arr = new int[] {12,15,88,96,45,22};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+ "");
            }
            max1 = max2 = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2)
                {
                    max2= arr[i];
                }
            }
            Console.WriteLine("The largest Number in Array is :" +max1);
            Console.WriteLine("The Secod largest Number in Array is :" +max2);
        }
    }
}
