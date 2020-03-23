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
			int[] nums = { 1, 2, 3, 4 };
			var result = ProductExceptSelf(nums);
			for (int i = 0; i < result.Length; i++) {
				Console.WriteLine("{0}", result[i]);
			}
			
			Console.ReadKey();
		}
		public static int[] ProductExceptSelf(int[] nums)
		{
			int size = nums.Length;
			var L = new int[size ];
			var R = new int[size ];
			L[0] = 1;
			R[size - 1] = 1;
			
			for (int i = 0; i < size - 1; i++) {
				L[i + 1] = L[i] * nums[i];
			}
			for (int i = size - 1; i > 0; i--) {
				R[i - 1] = R[i] * nums[i];
			}
			var result = new int[size];
			for (int i = 0; i < size; i++) {
				result[i] = L[i] * R[i];
			}
			return result;
		}
	}
	
	 
}