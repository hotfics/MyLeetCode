using System;
using System.Linq;

using System.Text;
using System.Collections.Generic;
namespace a
{
	class Solution
	{
		
		static void Main(string[] args)
		{
			Console.WriteLine("{0}", 5 / 2);
			Console.ReadKey();
		}
		public  static ListNode MiddleNode(ListNode head)
		{
			if (head == null) {
				return head;
			}
			if (head.next == null) {
				return head;
			}
			var list = new List<ListNode>();
			while (head != null) {
				list.Add(head);
				head = head.next;
			}
			int size = list.Count;			 
			return list[size / 2];			 
		}
	}
	
	 
}