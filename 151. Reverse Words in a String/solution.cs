using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
namespace a
{
	public class Solution
	{
		public static void Main()
		{
			string s = "  hello world!  ";
			var s1 = ReverseWords(s);
			
			Console.ReadLine();
		}
		
		public static string ReverseWords(string s)
		{
			var s1 = s.Split(' ').ToList().Where(x => x != "").Reverse();
		
			StringBuilder sb = new StringBuilder();
			foreach (var element in s1) {
				sb.Append(element);
				sb.Append(" ");				
			}
			string result = sb.ToString().TrimEnd();
			return result;
		}
		 
	}
}
