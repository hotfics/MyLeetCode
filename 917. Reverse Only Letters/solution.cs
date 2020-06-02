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
		var s =	ReverseOnlyLetters("a-bc-de");
		Console.WriteLine(s);
		Console.ReadLine();
    	
	}
	 
	public static string ReverseOnlyLetters(string S)
	{
		if (S == null) {
			return S;
		}
		char[] cs = S.ToCharArray();
		int len = S.Length;
		int i = 0;
		int j = len - 1;
		while (i < j) {
			if (char.IsLetter(cs[i])) {
				if (char.IsLetter(cs[j])) {
					char tmp = cs[i];
					cs[i] = cs[j];
					cs[j] = tmp;
					i++;
					j--;
				} else {
					j--;
				}
			} else {
				i++;
			}
		}
		return new String(cs);
	}
 

}
    
  
