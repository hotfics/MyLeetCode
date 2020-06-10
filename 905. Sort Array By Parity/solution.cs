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
			int[] a = { 3, 1, 2, 4 };
			var v = SortArrayByParity(a);
			foreach (var e in v) {
				Console.WriteLine(e);
			 	
			}
			
			Console.ReadLine();
		}
		public static int[] SortArrayByParity(int[] A)
		{
			var list = new LinkedList<int>();
			foreach (var a in A) {
				if (a % 2 == 0) {
					
					list.AddFirst(a);
				} else {
					list.AddLast(a);
				}
			}
			return list.ToArray();
		}
	
		
	 
	}
	
}
