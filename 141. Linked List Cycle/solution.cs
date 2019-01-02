/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
     if (head == null) return false;
            if (head.next == null) return false;
    
         
            ListNode fastNode = head.next.next;
            while (head.next!=null)
            {
                head = head.next;
                if (fastNode == null) return false;
                if (fastNode.next == null) return false;
                if (fastNode.next.next == null) return false;
                
                fastNode = fastNode.next.next;
                
               
                if (head == fastNode) return true;
               
            }
        return false;
    }
}