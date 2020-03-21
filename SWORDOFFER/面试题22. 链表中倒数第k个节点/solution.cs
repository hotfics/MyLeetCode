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
			
			Console.ReadKey();
		}
		public ListNode GetKthFromEnd(ListNode head, int k)
		{
			if (head == null) {
				return null;
			}
			
			int size = 0;
			ListNode origHead = head;
			while (head != null) {
				size++;
				head = head.next;
			}
			int n = size - k;
			int countNum = 0;
			while (origHead != null && countNum < n) {
				countNum++;
				origHead = origHead.next;
			}
			return origHead;
		}
	
		
		
		
	}
	 
}