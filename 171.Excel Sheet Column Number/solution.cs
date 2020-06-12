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
			var m=TitleToNumber("ZY");
			Console.WriteLine(m);
			Console.ReadLine();
		}
		public static int TitleToNumber(string s)
		{
			var len=s.Length;
			int sum=0;
			for (int i = 0; i < len-1; i++) {
				sum+= (s[i] - 'A' + 1)* (int)Math.Pow(26,len-i-1);
			}
			sum+=(s[len-1] - 'A' + 1);
			return sum;
			
			
		}
	 
	}
}
	

