using System;
using System.Collections.Generic;
using System.Linq;
namespace a
{
	class LetterCombinationOfAPhoneNumber
	{
		static void Main(string[] args)
		{
			int[] nums = { 3, 2, 3 };
	 
		 
			Console.ReadKey();
		}
		public int[] ReversePrint(ListNode head)
		{
		if (head == null) {
			return new  int[]{};
			}
			var stack = new Stack<int>();
				
			while (head.next != null) {
				stack.Push(head.val);
				head = head.next;
				
			}
			stack.Push(head.val);
			
            int size=stack.Count;
			int[] result = new int[size];
			for (int i = 0; i < size; i++) {
				result[i] = stack.Pop();
			}
			return result;

		}
		 

	}
}