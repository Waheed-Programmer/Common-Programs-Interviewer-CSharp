using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCsharp
{
    internal class CountingVowelsInArray
    {
        static void Main(string[] args)
        {
			int vowel = 0;
			int cons = 0;
			string[] arr = new string[] { "'a','A','e','E','i','I','o','O','g','m'" };
			foreach (var s in arr) // s is a string
			{
				for (int i = 0; i < s.Length; i++)
				{
					if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
					{
						vowel++;
					}
					else
						cons++;
				}
			}

			Console.WriteLine(vowel);
		}
    }
}
