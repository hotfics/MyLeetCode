using Microsoft.Win32;
using System;
using System.Threading;
using qq;
using System.Collections.Generic;

public  class VersionTest
{

	public static void Main()
	{
		ListNode n1 = new ListNode(1);
		ListNode n2 = new ListNode(2);
 
		n1.next = n2;
	 
		n2.next = null;
		var h = RotateRight(n1, 2);
		while (h.next != null) {
			Console.WriteLine("{0}", h.val);
			h = h.next;
		}
		Console.WriteLine("{0}", h.val);
    	
		Console.ReadLine();
    	
	}
	public static ListNode RotateRight(ListNode head, int k)
	{
		if ((head == null) || (head.next == null) || k == 0) {
			return head;
		}
		ListNode h = head;
		ListNode h1 = head;
		
		int len = 0;
		while (head.next != null) {
			len++;
			head = head.next;
		}
		len++;
		int _k = k % len;
		if (_k == 0) {
			return h;
		}
		 
		ListNode dummy = new ListNode(0);
		List<ListNode> kList = new List<ListNode>();
		List<ListNode> l_kList = new List<ListNode>();
		int count = 0;
		while (h1.next != null) {
			count++;
			if (count <= len - _k) {
				l_kList.Add(h1);
			} else {
				kList.Add(h1);
			}
			h1 = h1.next;
			
		}
		kList.Add(h1);
		dummy.next = kList[0];
		int kcount = _k;
		for (int i = 0; i < kcount - 1; i++) {
			if (i + 1 < kcount) {
				kList[i].next = kList[i + 1];
			}	
		}
		int l_kcount = len - _k;
		kList[kcount - 1].next = l_kList[0];
		for (int i = 0; i < l_kcount - 1; i++) {
			if (i + 1 < l_kcount) {
				l_kList[i].next = l_kList[i + 1];
			}	
		}
		l_kList[l_kcount - 1].next = null;
		return dummy.next;
		
	 
 	
	}
	

}
    
  
