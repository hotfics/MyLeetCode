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
			ListNode n2 = new ListNode(1);
//			ListNode n3 = new ListNode(1);
//			ListNode n4 = new ListNode(2);
//			ListNode n5 = new ListNode(3);
//			ListNode n6 = new ListNode(4);
//			ListNode n7 = new ListNode(5);
			n1.next = n2;
			n2.next = null;
//			n3.next = n4;
//			n4.next = n5;
//			n5.next=null;
//			n5.next = n6;
//			n6.next = n7;
			DeleteDuplicates(n1);
			Console.ReadKey();
		}
		public static ListNode DeleteDuplicates(ListNode head)
		{
			if (head == null) {
				return head;
			}
			var list = new List<int>();
			
			ListNode node = head;
			while (head != null) {
				list.Add(head.val);
				head = head.next;
			}
		 
			var uniqueList =	list.GroupBy(x => x)
			.Where(w => w.Count() == 1)
			.Select(s => s.ElementAt(0)).ToList();
			if (uniqueList.Count == 0) {
				return null;
			}
			var nodelist = new List<ListNode>();
			foreach (var element in uniqueList) {
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