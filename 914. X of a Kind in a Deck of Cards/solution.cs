using System.Collections.Generic;
using System.Linq;
using System;
public class Solution
{
	public static void Main()
	{
		int[] nums = {1, 1, 1, 1, 1, 0, 0, 0
		};
		Console.WriteLine(HasGroupsSizeX(nums));
		Console.ReadLine();
	}
	public static bool HasGroupsSizeX(int[] deck)
	{	
		if (deck.Length == 1)
			return false;
		IList<int> list = deck.Distinct().ToList();
		int size = list.Count;
		var listCount = new List<int>();		 
		for (int i = 0; i < size; i++) {
			int c_num = deck.Count(x => x == list[i]);
			listCount.Add(c_num);  
		}
		int g = 0;
		for (int i = 0; i < listCount.Count; i++) {
			if ((g = gcd(listCount[i], g)) == 1) {
				return false;
			} 
		}
		return true;
	}
	private static int   gcd(int a, int b)
	{
		if (b == 0)
			return a;
		return gcd(b, a % b);
	}
}