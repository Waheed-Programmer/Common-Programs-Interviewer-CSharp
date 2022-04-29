using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCsharp
{
    internal class Armstrong_Number
    {
        public static void Main(string[] args)
        {
            int num, temp, sum = 0, rem;
            Console.WriteLine("Please Enter Integer");
            num = Convert.ToInt32(Console.ReadLine());           
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("The Number are Armstrong");
            }
            else
            {
                Console.WriteLine("The Number are not Armstrong");

            }
        }
    }
}
