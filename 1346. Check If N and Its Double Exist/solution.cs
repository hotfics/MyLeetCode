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
			int[] a = { 0, 0 };
			 
			Console.WriteLine(CheckIfExist(a));
			Console.ReadLine();
		}
		public static bool CheckIfExist(int[] arr)
		{	 
			var list = arr.ToList();
			for (int i = 0; i < arr.Length; i++) {
				if (arr[i] == 0) {
					if (list.Count(x => x == 0) > 1) {
						return true;
					}	
					continue;
				}
				if (list.FindIndex(x => x == 2 * arr[i]) != -1) {
					return true;
				}					
			}
			return false;			 
		}

	}
}
	

