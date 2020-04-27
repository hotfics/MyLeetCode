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
			decimal a = 6;
			ArrayList SelfPrivArr = new ArrayList();
			SelfPrivArr.Add(a);
			bool b = SelfPrivArr.Contains((decimal)6);
			Console.ReadLine();
		}
		
		public static int Search(int[] nums, int target)
		{
			int left = 0;
			int right = nums.Length - 1;
			while (left <= right) {
				int mid = (left + right) / 2;
				if (nums[mid] == target) {
					return mid;
				}
				if (nums[left] <= nums[mid]) {
					if ((nums[left] <= target) && (target <= nums[mid])) {
						right = mid - 1;
					} else {
						left = mid + 1;
					}
				} else {
					if ((target <= nums[right]) && (nums[mid] <= target)) {
						left = mid + 1;
					} else {
						right = mid - 1;
					}
				}
			}
			return -1;
		}	
		 
	}
}
