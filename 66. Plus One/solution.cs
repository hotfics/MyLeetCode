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
			int[] num = { 0 };
			var r = PlusOne(num);
			for (int i = 0; i < r.Length; i++) {
				Console.WriteLine("{0}", r[i]);
			}
			
	
			Console.ReadLine();
		}
		public static int[] PlusOne(int[] digits)
		{
			int l = digits.Length - 1;
	
			int carry = 0;
			int plus = 1;
	
			IList<int> list = new List<int>();
			while (l >= 0 || carry != 0) {
				int a = l < 0 ? 0 : digits[l--];	
				int sum = 0;
			
				sum = sum + a + carry + plus;
				if (plus > 0) {
					plus--;
				}
				if (sum >= 10) {
					carry = 1;
					sum = sum - 10;
				} else {
					carry = 0;
				}
				list.Add(sum);
			}
			return 	list.Reverse().ToArray();
		}
	 
	}
}
