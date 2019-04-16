package com.company;

public class Main {

    public static void main(String[] args) {
        ListNode n1 = new ListNode(3);
        ListNode n2 = new ListNode(2);
        ListNode n3 = new ListNode(0);
        ListNode n4 = new ListNode(-4);
        n1.next = n2;
        n2.next = n3;
        n3.next = n4;
        n4.next = n2;
        ListNode node = detectCycle(n1);
        System.out.println(node.val);
        System.out.println();
    }
    public static ListNode detectCycle(ListNode head) {
        if (head == null || head.next == null || head.next.next == null) return null;
        if (head.hashCode() == head.next.hashCode()) return head;
        ListNode fast = head;
        ListNode slow = head;
        while (fast != null && fast.next != null) {
            if (fast.next.next == null) return null;
            fast = fast.next.next;
            slow = slow.next;
            if (fast == slow) break;
        }
        if (fast == null || slow == null) return null;
        fast = head;
        while (fast != slow) {
            if (fast.next == null || slow.next == null) return null;
            fast = fast.next;
            slow = slow.next;
        }
        return slow;
    }
}










