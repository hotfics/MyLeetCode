using System;
using System.Collections.Generic;
using System.Linq;
namespace LetterCombinationOfAPhoneNumber
{
	//build a temp result to descese and add each charactor in the  "numberOfWord"
	class LetterCombinationOfAPhoneNumber
	{
		static void Main(string[] args)
		{
			var test = letterCombinations(""); 
			foreach (var element in test) {
				Console.WriteLine("{0}", element);
			}
			Console.ReadKey();
		}

		public static IList<string> letterCombinations(String digits)
		{
			var dic = new Dictionary<string,string>();
			dic.Add("2", "abc");
			dic.Add("3", "def");
			dic.Add("4", "ghi");
			dic.Add("5", "jkl");
			dic.Add("6", "mno");
			dic.Add("7", "pqrs");
			dic.Add("8", "tuv");
			dic.Add("9", "wxyz");
			IList<string> result = new List<string>();
		
			if (string.IsNullOrEmpty(digits))
				return result;
			
			if (digits.Length == 1) {
				string keyString = dic[digits];
				foreach (var element in keyString) {
					result.Add(element.ToString());
				}
				return result;
			}
			
			IList<string> digStrings = new List<string>();
			for (int i = 0; i < digits.Length; i++) {
				string key = digits[i].ToString();
				digStrings.Add(dic[key]);
			}
			result.Add("");
			for (int j = 0; j < digStrings.Count; j++) {
				IList<string> tmpResu = new List<string>();
				for (int i = 0; i < result.Count; i++) {
					for (int k = 0; k < digStrings[j].Length; k++) {
						tmpResu.Add(result[i] + digStrings[j][k]);
					}
				}
				result = tmpResu;
        		
        		
			}
        	
			return result;
		}

	}
}