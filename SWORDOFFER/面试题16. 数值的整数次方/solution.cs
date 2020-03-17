using System;
using System.Linq;
namespace a
{
	class solution
	{
		static void Main(string[] args)
		{

			//Console.WriteLine("{0}", MyPow(2, 10));
			//Console.WriteLine("{0}", MyPow(2.1, 3));
			Console.WriteLine("{0}", MyPow(1, -2147483648));
			Console.ReadKey();
		}
		public static double MyPow(double x, int n)
		{
			 
			long exponent = Math.Abs(long.Parse(n.ToString()));
			double _base = x;
			double result = 1;
			while (exponent != 0) {
				if ((exponent & 0x01) > 0) {
					result *= _base;
					
				}
				_base = _base * _base;
				
				exponent =	exponent >> 1;
			}
			if (n > 0) {
				return  result;
			} else {
				return 1 / result;
			}
	
		}
			
		
	}
	 
}