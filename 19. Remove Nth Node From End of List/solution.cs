using System.Collections.Generic;
using System.Linq;
using System;
namespace a
{
	public class Solution
	{
		public static void Main()
		{
			ListNode n1 = new ListNode(1);
			ListNode n2 = new ListNode(2);
			ListNode n3 = new ListNode(3);
			ListNode n4 = new ListNode(4);
			ListNode n5 = new ListNode(5);
			ListNode n6 = new ListNode(8);
			ListNode n7 = new ListNode(0);
			n1.next = n2;
			n2.next = n3;
			n3.next = n4;
			n4.next = n5;
			n5.next = n6;
			n6.next = n7;
			n7.next = null;
			ListNode node =	RemoveNthFromEnd(n1, 2);
			while (node != null) {
				Console.WriteLine("{0}", node.val);
				node = node.next;
			}
			Console.ReadLine();
		}
		public static ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			
			if ((head == null)) {
				return head;
			}
			if ((head.next == null)) {
				return null;
			}
			ListNode headNode = head;
			var list = new List<int>();
			while (head != null) {
				list.Add(head.val);
				head = head.next;				
			}
			list.RemoveAt(list.Count - n);
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
