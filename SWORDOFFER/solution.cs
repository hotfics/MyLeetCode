
using System.Collections.Generic;
using System.Linq;
using System;
namespace a
{//f(N,M)=(f(N−1,M)+M)%N
	public class Solution
	{
		public static void Main()
		{
			Console.WriteLine("{0}", LastRemaining(5, 3));	
			Console.ReadLine();
		}
		public static int LastRemaining(int n, int m)
		{
			int p = 0;
			for (int i = 2; i <= n; i++) {
				p = (p + m) % i;
			}
			return   p;
		}
	 
		 
	}
}
