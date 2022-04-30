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
			//Count Vowel in array
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

			Console.Write("\nVowels in the string: {0}\n", vowel);

			Console.WriteLine("====================================>");

			//Count vowel in string
			string myStr = "Avengers"; 
			int len, vowel_count=0, cons_count=0;
						
			// find length
			len = myStr.Length;
			for (int i = 0; i < len; i++)
			{
				if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
				{
					vowel_count++;
				}
				else
				{
					cons_count++;
				}
			}
			Console.Write("\nVowels in the string: {0}\n", vowel_count);
		}
    }
}
