using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCsharp
{
    internal class PrimeNumber
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Integer");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i < num/2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false; break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("The Integer is Prime Number");
            }
            else
            {
                Console.WriteLine("The Integer is not a Prime Number");

            }
        }
    }
}
