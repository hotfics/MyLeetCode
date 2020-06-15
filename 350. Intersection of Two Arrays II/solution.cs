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
			int[]	nums1 = { 1, 2, 2, 1 }, nums2 = { 2 };
			var r = intersect(nums1, nums2);
			foreach (var v in r) {
				Console.WriteLine(v);
			}
			Console.ReadLine();
		}
		public static int[] intersect(int[] nums1, int[] nums2)
		{
			IList<int> listR = new List<int>();
			var list1 = nums1.ToList();
			var list2 = nums2.ToList();
			var list3 =	list1.Intersect(list2);
			foreach (var v in list3) {
				var count1 =	list1.Count(x => x == v);
				var count2 =	list2.Count(x => x == v);
				
				for (int i = 0; i < Math.Min(count1, count2); i++) {
					listR.Add(v);
				}
			}
			return listR.ToArray();
		}
	 
	}
}
	

