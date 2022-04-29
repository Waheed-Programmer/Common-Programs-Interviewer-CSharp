using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCsharp
{
    internal class PalindromeNumber
    {
        static void Main(string[] args)
        {
            int num, temp, rem, rev=0;
            Console.WriteLine("Enter Integer");
            num= Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                rev = rev*10 + rem;
                num = num / 10;

            }
            if (rev == temp)
            {
                Console.WriteLine("Number are Palindram");
            }
            else
            {
                Console.WriteLine("Nuber Are not Palindrom");
            }

        }
    }
}
