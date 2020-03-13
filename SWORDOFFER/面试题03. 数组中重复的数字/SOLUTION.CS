using System;
using System.Collections.Generic;
using System.Linq;
namespace LetterCombinationOfAPhoneNumber
{
	class LetterCombinationOfAPhoneNumber
	{
		static void Main(string[] args)
		{
			int[] nums = { 3, 2, 3 };
			FindRepeatNumber(nums);
		 
			Console.ReadKey();
		}
		public static int FindRepeatNumber(int[] nums)
		{
			Array.Sort(nums);
			for (int i = 0; i < nums.Length; i++) {
				
				
				if (nums[i] == nums[i + 1]) {
					return nums[i];
				}
			}
			return nums[0];
		}

	}
}