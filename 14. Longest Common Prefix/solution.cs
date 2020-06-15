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
			string[] ss = { "c", "c"
			};
			var s = LongestCommonPrefix(ss);
			Console.WriteLine(s);
			Console.ReadLine();
		}
		public static string LongestCommonPrefix(string[] strs)
		{
			var len = strs.Length;
			if (len == 1) {
				return strs[0];
			}
			if (len == 0) {
				return "";
			}
			var sb = new StringBuilder();
			var r = strs.OrderBy(x => x.Length).ToList();
			for (int i = 0; i < r[0].Length; i++) {
				int j = 1;
				while (j < len) {
					if (r[0][i] == r[j][i]) {						
						j++;	
					} else {
						return sb.ToString();
					}
				}
				sb.Append(r[0][i]);
 
			}			
			return sb.ToString();
		}
	}
}
	

