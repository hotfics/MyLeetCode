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
			int[] nums = { 3, 2, 2, 3 };
			var result = RemoveElement(nums, 3);			 
			Console.WriteLine("{0}", result);	
			Console.ReadKey();
		}
		public static  int RemoveElement(int[] nums, int val)
		{ 
			int size = nums.Length;
			if (size == 0) {
				return 0;
			}
			int k = 0;
			for (int i = size - 1; i >= 0; i--) {
				if (nums[i] == val) {
					swap(ref nums[i], ref nums[size - 1 - k]);
					k++;			 
				} 			
			}
			return size - k;
		}
		
		private static void swap(ref int a, ref int b)
		{
			int t = a;
			a = b;
			b = t;
		}
		 
	}
	
	 
}