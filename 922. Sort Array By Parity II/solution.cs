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
		 
		Console.ReadLine();
    	
	}
	 
	public int[] SortArrayByParityII(int[] A)
	{
		int len = A.Length;
		IList<int> result = new List<int>();
		IList<int> odd = new List<int>();
		IList<int> even = new List<int>();
		for (int i = 0; i < len; i++) {
			if (A[i] % 2 == 0) {
				even.Add(A[i]);
			} else {
				odd.Add(A[i]);			
			}
		}
		for (int i = 0; i < len / 2; i++) {
			result.Add(even[i]);
			result.Add(odd[i]);			
		}
		return result.ToArray();
	}
	 

}
    
  
