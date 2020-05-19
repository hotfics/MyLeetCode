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
			string s = "pidbliassaqozokmtgahluruufwbjdtayuhbxwoicviygilgzduudzgligyviciowxbhuyatdjbwfuurulhagtmkozoqassailbdip";
			//Console.WriteLine(newString(s,3));
			Console.WriteLine(ValidPalindrome(s));
			//Console.WriteLine(IsValidPalindrome(s));
			
			Console.ReadLine();
		}
		public static bool ValidPalindrome(string s)
		{
			var b =	IsValidPalindrome(s);
			if (b) {
				return b;
			}
			int len = s.Length;		
			int j = len - 1;
			for (int i = 0; i < len; i++) {
				if (s[i] != s[j]) {
					bool b1 =	IsValidPalindrome(newString(s, i));
					return !b1 ? IsValidPalindrome(newString(s, j)) : b1;
				}
				j--;
				if (j == i) {
					break;
				}
			}
			return false;
		}
		public static string newString(string s, int i)
		{
			
			string result = s.Remove(i, 1);
			return result;
		}
		public static bool IsValidPalindrome(string str)
		{
			int begin = 0;
			int end = str.Length - 1;
			while (begin <= end) {
				if (str[begin] == str[end]) {
					begin++;
					end--;
				} else
					return false;
			}
			return true;
 
		}
	}
}
