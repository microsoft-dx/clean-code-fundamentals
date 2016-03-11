using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
	class AnagramCheck
	{
		public static bool areAnagrams(string s, string t) 
		{
			int i = 0;
			int currentPosition;
			string space = " ";

			if (t.Length != s.Length)
				return false;
			
			if (t.Length == 1)
			if (t.ElementAt(0) == s.ElementAt(0))
				return true;
			else
				return false;

			while (i < s.Length)
			{
				currentPosition = t.IndexOf(s.ElementAt(i));
				if (currentPosition  != -1)
				{
					t = t.Remove(currentPosition, 1);
					t = t.Insert(currentPosition, " ");
				}
				else
				{
					return false;
				}
				i++;
			}
			return true;
	}

		static void Main(string[] args)
		{
			Console.WriteLine("test");

			if (areAnagrams("abdc", "dbac") == true)
				Console.WriteLine("ha ha!");

		}
	}
}
