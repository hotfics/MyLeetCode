using System;
using System.Linq;
namespace a
{
	class solution
	{
		static void Main(string[] args)
		{

			foreach (var element in PrintNumbers(0)) {
				Console.Write("{0} ", element);
			}
			
			Console.ReadKey();
		}
		public static int[] PrintNumbers(int n)
		{
			if (n == 0) {
				return new int[]{ };
			}
			int[] result = new int[Convert.ToUInt32(Math.Pow(10, n)) - 1];
			int size = result.Length;
			for (int i = 0; i < size; i++) {
				result[i] = i + 1;
			}
		 
			return result;
		}
			
		
	}
	 
}