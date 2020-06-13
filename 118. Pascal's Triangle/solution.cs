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
		 
		var e = Generate(9);
		foreach (var a in e) {
			foreach (var i in a) {
				Console.Write(i.ToString() + " ");
					
			}
			Console.WriteLine("-----");
		}
		Console.ReadLine();
	}
	 	
	 
	 
	public static IList<IList<int>> Generate(int numRows)
	{
		if (numRows == 0) {
			return  new List< IList<int>>();
		}
		var lists = new List< IList<int>>();		 
		lists.Add(new List<int>{ 1 });
		if (numRows == 1) {
			return    lists;
		}
		lists.Add(new List<int>{ 1, 1 });
		if (numRows == 2) {
			return       lists;
		}			
		lists.Add(new List<int>{ 1, 2, 1 });
		if (numRows == 3) {
			return  lists;
		}		 
		for (int i = 3; i < numRows; i++) {
			var list = new List<int>();
			list.Add(1);
			int listCount = lists[i - 1].Count;				
			for (int j = 0; j < listCount - 1; j++) {
				int sum = 0;
				if (j + 1 < listCount) {
					sum = lists[i - 1][j] + lists[i - 1][j + 1];
				}
				if (sum > 0) {
					list.Add(sum);
				}		 
			}
			list.Add(1);
			lists.Add(list);	
		}
		return lists;
   
	}
}
	

    
  
