using System;
using System.Collections.Generic;
using System.Linq;
namespace a
{
	class LetterCombinationOfAPhoneNumber
	{
		static void Main(string[] args)
		{
			Console.WriteLine("{0}", Fib(48));	 
			Console.ReadKey();
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