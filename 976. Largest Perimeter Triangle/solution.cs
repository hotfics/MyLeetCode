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
		int[] n = { 2, 1, 2 };
		var l =	LargestPerimeter(n);
		Console.WriteLine(l);
		Console.ReadLine();  	
	}
	 
	public static int LargestPerimeter(int[] A)
	{
		int len = A.Length;
		Array.Sort(A);
		for (int i = len - 1; i >= 0; i--) {
			int a = A[i];
			if (i - 1 < 0 || i - 2 < 0) {
				break;
			}
			int b = A[i - 1];
			int c = A[i - 2];
			if (validate(a, b, c)) {
				return a + b + c;
			} else {
				int tail = i - 3;
				if (tail < 0) {
					break;
				}
				while (tail > 0) {
					if (validate(a, b, A[tail--])) {
						return a + b + A[tail];
					}	
				}				
			}
		}
		return 0;		
	}
	public static bool validate(int a, int b, int c)
	{
		if (a + b > c) {
			if (a + c > b) {
				if (b + c > a) {
					return true;
				}
			}
		} 
		return false;
	}
}
    
  
