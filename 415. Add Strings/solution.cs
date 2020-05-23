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
		
		Console.WriteLine("{0}", AddStrings("1", "9"));
    	
		Console.ReadLine();
    	
	}
	public static string AddStrings(string num1, string num2)
	{
		int i = num1.Length - 1;
		int j = num2.Length - 1;		
		int carry = 0;
		int sum = 0;
		var sb = new StringBuilder();
		while (i >= 0 || j >= 0 || carry > 0) {
			int a = 0;
			int b = 0;			 		 
			if (i < 0) {
				a = 0;
			} else {
				a = num1[i--] - '0';
			}
			if (j < 0) {
				b = 0;
			} else {
				b = num2[j--] - '0';
			}			
			sum = a + b + carry;
			if (sum >= 10) {
				carry = 1;
				sum = sum - 10;
			} else {
				carry = 0;
			}
			sb.Append(sum);					
		}
		return new String(sb.ToString().ToCharArray().Reverse().ToArray());
	}
	

}
    
  
