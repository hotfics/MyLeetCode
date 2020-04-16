using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
namespace a
{
	public class Solution
	{
		public class MyComparor:IComparer<int[]>
		{
			public int Compare(int[] x, int[] y)
			{
				return  x[0] - y[0];
			}
		}
		public static void Main()
		{
			string s = "  hello world!  ";
			int[][] a = new int[][] {
				new int[]{ 1, 3 },
				new int[]{ 2, 6 },
				new int[]{ 8, 10 },
				new int[] {
					15,
					18
				}
			};
			Merge(a);
			Console.ReadLine();
		}
		
		public static int[][] Merge(int[][] intervals)
		{
			if ((intervals == null) || (intervals.Length <= 1)) {
				return intervals;
			}
			List<int[]> list = new List<int[]>();
			Array.Sort(intervals, new MyComparor());
			int n = intervals.GetLength(0);
			int i = 0;
			while (i < n) {
				int left = intervals[i][0];
				int right = intervals[i][1];
				
				while (i < n - 1 && right >= intervals[i + 1][0]) {
					right = Math.Max(right, intervals[i + 1][1]);
					i++;
				}
				list.Add(new int[]{ left, right });
				i++;
				
			}
			return list.ToArray();
			
		}
		 
	}
}
