using System.Text;
using Microsoft.Win32;
using System;
using System.Threading;
using qq;
using System.Collections.Generic;
using System.Linq;

public  class VersionTest
{
	public static void Main()
	{ 
		int[] n = { 100, 4, 200, 1, 3, 2 };
		var l =	LongestConsecutive(n);
		Console.WriteLine(l);
		Console.ReadLine();
    	
	}
	 
	public static int LongestConsecutive(int[] nums)
	{
		int max = 0;
		var map = new Dictionary<int,int>();
		foreach (var n in nums) {
			if (map.ContainsKey(n)) {
				continue;
			} else {
				int leftvalue = 0, rightvalue = 0;
				map.TryGetValue(n - 1, out leftvalue);
				map.TryGetValue(n + 1, out rightvalue);
				int cur = leftvalue + rightvalue + 1;
				if (cur > max) {
					max = cur;
				}
				map[n] = cur;
				map[n - leftvalue] = cur;
				map[n + rightvalue] = cur;
			 
			}
		}
		return max;
	}
	 

}
    
  
