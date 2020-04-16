using System.Collections.Generic;
using System.Linq;
using System;
namespace a
{
	public class Solution
	{
		public static void Main()
		{	
			Console.ReadLine();
		}
		public static int MaxDepth(TreeNode root)
		{
			if (root == null) {
				return 0;
			}
			int depthLeft = MaxDepth(root.left);
			int depthRight = MaxDepth(root.right);			 
			return Math.Max(depthLeft, depthRight) + 1;
		 
		}
		 
	}
}
