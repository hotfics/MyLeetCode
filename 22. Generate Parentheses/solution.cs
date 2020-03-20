using System;
using System.Linq;

using System.Text;
using System.Collections.Generic;
namespace a
{
	class Solution
	{
		
		static void Main(string[] args)
		{		
			var list = generateParenthesis(3);
			foreach (var element in list) {
				Console.WriteLine("{0}", element);
			}
			Console.ReadKey();
		}
		public static List<string>  GenerateParenthesis(int n)
		{
			return filter(n);
		}
		public static List<string> generateAllParenthesis(int n)
		{
			string left = "(";
			string right = ")";
			
			int len = n * 2;
			var list = new List<string>();
			list.Add(left);
		
			while (len - 1 > 0) {
				var tmpList = new List<string>();
				foreach (var element in list) {
					string tmpLeft = element + left;
					string tmpRight = element + right;
					tmpList.Add(tmpLeft);
					tmpList.Add(tmpRight);
					
				}
				list = tmpList;
				len = len - 1;
				
			}
			return list;
			 
		}
		public static  List<string> filter(int n)
		{
			var list = new List<string>();
			var alllist = generateAllParenthesis(n);
			foreach (var element in alllist) {
				if (notBalance(element)) {
					continue;
				} else {
					if (Validate(element)) {
						list.Add(element);
					}
				
				}
				
			}
			return  list;
		
		}
		public static bool notBalance(string str)
		{
			var leftcount =	str.Count(x => x == '(');
			var rightcount =	str.Count(x => x == ')');
			return leftcount != rightcount;
	
		}
		public static bool Validate(string str)
		{
			int index = 0;
			while (str.Length > 0) {
				var start = str[0];
				if (start == ')') {
					return false;
				}
				for (int i = 0; i < str.Length; i++) {
					if (str[i] == ')') {
						index = i;
						break;
					}
				}
				str = str.Remove(index, 1).Remove(0, 1);
			 
			}
			return true;
		
		}
		
		
	}
	 
}