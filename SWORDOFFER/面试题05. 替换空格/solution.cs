using System;
using System.Collections.Generic;
using System.Linq;
namespace LetterCombinationOfAPhoneNumber
{
	class LetterCombinationOfAPhoneNumber
	{
		static void Main(string[] args)
		{
			int[] nums = { 3, 2, 3 };
			string s = "We are happy.";
			Console.WriteLine("{0}", ReplaceSpace(s));
		 
			Console.ReadKey();
		}
		public  static string ReplaceSpace(string s)
		{
			return s.Replace(" ", "%20");
		}

	}
}