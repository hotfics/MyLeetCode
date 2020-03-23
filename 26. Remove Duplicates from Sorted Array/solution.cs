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
			int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
			var result = RemoveDuplicates(nums);
			 
			Console.WriteLine("{0}", result);
		 
			
			Console.ReadKey();
		}
		public static int RemoveDuplicates(int[] nums)
		{//slow
			if (nums.Length == 0)
				return 0;
			int k = 0;
			int j = 0;
			int size = nums.Length;
			for (int i = 0; i < size; i++) {
				k = i;
				j = k;
				if ((k + 1 < size) && (nums[k + 1] == nums[j])) {
					j = k + 1;
					while ((j < size) && (nums[j] == nums[k])) {
						j++;
					}
				}
				
				if (k < j) {
					int index =	k;
					for (int u = j - 1; u < size; u++) {
						nums[index++] = nums[u];
					}					
				} 				
			}
			int r = 0;
			while ((r + 1 <= size - 1) && (nums[r] < nums[r + 1])) {
				r++;
			}
			return r + 1;
		}
		
		 
	}
	
	 
}