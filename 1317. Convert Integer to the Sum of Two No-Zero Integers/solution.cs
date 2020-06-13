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
		int n = 4102;
		var ns =	GetNoZeroIntegers(n);
		foreach (var i in ns) {
			Console.WriteLine(i);
		}
		Console.ReadLine();  	
	}
	 	
	public static int[] GetNoZeroIntegers(int n)
	{
		for (int i = 1; i < n; i++) {
			if (validate(i, n)) {
				
				return new int[]{ i, n - i };
			}	
		}
		return new int[]{ };
	}
	public static bool validate(int i, int n)
	{
		if (i.ToString().IndexOf('0') != -1) {
			return false;
		}
		if ((n - i).ToString().IndexOf('0') != -1)
			return false;
		else
			return true;
	}
}
    
  
