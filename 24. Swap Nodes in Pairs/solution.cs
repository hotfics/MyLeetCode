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
			ListNode n1 = new ListNode(1);
			ListNode n2 = new ListNode(2);
			ListNode n3 = new ListNode(3);
			ListNode n4 = new ListNode(4);
			n1.next = n2;
			n2.next = n3;
			n3.next = n4;
			n4.next = null;
			var p =	SwapPairs(n1);
			while (p != null) {
				Console.WriteLine("{0}", p.val);
				p = p.next;
			}		 
			Console.ReadKey();
		}
		public static ListNode SwapPairs(ListNode head)
		{
			if ((head == null)) {
				return head;
			}
			if ((head.next == null)) {
				return head;
			}
			ListNode p = head;
			IList<int> list = new List<int>();
			while (head != null) {
				list.Add(head.val);
				head = head.next;
			}
			for (int i = list.Count - 1; i >= 0; i--) {
				if (i % 2 != 0) {
					int t = list[i];
					list[i] = list[i - 1];
					list[i - 1] = t;
				}
			}
			var nodelist = new List<ListNode>();
			foreach (var element in list) {
				var _node = new ListNode(element);
				nodelist.Add(_node);
			}
			for (int i = 0; i < nodelist.Count - 1; i++) {
				nodelist[i].next = nodelist[i + 1];
			}
			nodelist[nodelist.Count - 1].next = null;
			return nodelist[0];
		
		}
	}
	
	 
}