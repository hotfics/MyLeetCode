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
		var b = JudgeSquareSum(14);
		 
		Console.WriteLine(b);
	
		Console.ReadLine();  	
	}
	 	
	public static bool JudgeSquareSum(int c)
	{		 
		int j = Convert.ToInt32(Math.Sqrt(c));
		int i = 0;
		while (i <= j) {
			int z = i * i + j * j;
			if (z == c) {
				return true;
			}
			if (z > c) {
				j--;
			} else {
				i++;
			}
		}
		 
		return false;
	}
}
    
  
