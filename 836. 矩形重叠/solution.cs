using System;
using System.Linq;
using System.Collections.Generic;
namespace a
{
	class solution
	{
		//reverse exclude
		static void Main(string[] args)
		{		
			int[] re1 = { 7, 8, 13, 15 };
			int[] re2 = { 10, 8, 12, 20 };
		 
			Console.WriteLine(IsRectangleOverlap(re1, re2));
			Console.ReadKey();
		}
		public static bool IsRectangleOverlap(int[] rec1, int[] rec2)
		{
			
			return  !((rec2[2] <= rec1[0]) || (rec2[3] <= rec1[1]) ||
			(rec2[0] >= rec1[2]) || (rec2[1] >= rec1[3]));
				
		}
		
		
	}
	 
}