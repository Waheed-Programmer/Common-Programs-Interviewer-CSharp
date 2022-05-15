using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCsharp
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            string str, revers = "";
            Console.WriteLine("Enter String");
            str = Console.ReadLine();
            str = str.ToLower();
            for (int i = str.Length-1; i>=0; i--)
            {
                revers = revers + str[i];
            }
            Console.WriteLine("The String is {0}:",revers);
        }
    }
}
