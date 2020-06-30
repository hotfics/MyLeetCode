using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System;
using System.Text;
using System.Net.Http;

namespace a
{
	public class Solution
	{
		public static void Main()
		{	
			var s = "A man, a plan, a canal: Panama";
			Console.WriteLine(IsPalindrome(s));
			Console.ReadLine();
		}
		public  static bool IsPalindrome(string s)
		{
			if (s == "") {
				return true;
			}
			s = s.ToLower();
			int i=0;
			int l = s.Length;
			int j = l - 1;
			while (i < j) {
				if (char.IsLetterOrDigit(s[i])) {
					if (char.IsLetterOrDigit(s[j])) {
						if (s[i] == s[j]) {
							i++;
							j--;
						} else {
							return false;
						}
							
					} else {
						j--;
					}
				} else {
					i++;
				}
			} 
			return true;
		}
				
				

	}
	   
}


