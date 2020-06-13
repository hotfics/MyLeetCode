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
		Console.WriteLine(ConvertToTitle(52
		));
		
		Console.ReadLine();
	}
	public static string ConvertToTitle(int n)
	{
	 
		var sb = new StringBuilder();
		while (n > 0) {
			n--;
			var num = n % 26;			 
			n = n / 26;
			sb.Append((char)(num + 'A'));				
		}
		
		return Reverse(sb.ToString());
	}
	public static string Reverse(string text)
	{
		char[] cArray = text.ToCharArray();
		string reverse = String.Empty;
		for (int i = cArray.Length - 1; i > -1; i--) {
			reverse += cArray[i];
		}
		return reverse;
	}
	 
 
}

    
  
