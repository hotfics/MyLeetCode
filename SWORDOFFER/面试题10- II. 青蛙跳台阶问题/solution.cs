using System;
using System.Collections.Generic;
using System.Linq;
namespace a
{
	class LetterCombinationOfAPhoneNumber
	{
		static void Main(string[] args)
		{
			Console.WriteLine("{0}", NumWays(3));
	 
		 
			Console.ReadKey();
		}
		public static int NumWays(int n)
		{
			if (n == 1) {
				return 1;
			}
			if (n == 2) {
				return 2;
			}
			decimal oneStep = 1;
			decimal twoStep = 2;
			int count = 2;
			decimal sum = 0;
			while (count < n) {
				sum = oneStep + twoStep;
				oneStep = twoStep;
				twoStep = sum;
				count++;
        	
			}
			return (int)(sum % 1000000007);

		}
		
		public static int Fib(int n)
		{
			if (n < 2)
				return n;
        
			decimal first = 0;
			decimal second = 1;
			int count = 1;
			decimal sum = 0;
			while (count < n) {
				sum = first + second;
				first = second;
				second = sum;
				count++;
        	
			}
			return (int)(sum % 1000000007);

      
		}
		 

	}
}