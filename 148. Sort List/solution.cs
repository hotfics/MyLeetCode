/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SortList(ListNode head) {
      if (head == null) return null;
            Comparison<ListNode> p = (ListNode A, ListNode B) => {
                if (A.val < B.val) return -1;
                else if (A.val == B.val) return 0;
                else if (A.val > B.val) return 1;
                return 0;
            };
            List<ListNode> list = new List<ListNode>();
            while (head!=null)
            {
                list.Add(head);
                head = head.next;                
            }    
            list.Sort(p);
            for (int i = 0; i < list.Count; i++)
            {
                if (i==list.Count-1)
                {
                  list[i].next =null; 
                }
                else
                {
                     list[i].next = list[i + 1];
                }
            }           
            return list[0];
    }
}