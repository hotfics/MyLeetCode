using System;
using System.Collections.Generic;
using System.Linq;
namespace a
{
	class solution
	{
		static void Main(string[] args)
		{
			Console.WriteLine("{0}", HammingWeight(8));
	 	 
			Console.ReadKey();
		}
			
		public static int HammingWeight(uint n)
		{
			int coutn = 0;
			while (n != 0) {
				coutn++;
				n &= (n - 1);
			}
			return coutn;
				
		}
			
		
	}
	 
}