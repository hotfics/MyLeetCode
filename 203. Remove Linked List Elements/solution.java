package com.company;

public class Main {
    public static void main(String[] args) {
        ListNode n1 = new ListNode(1);
        ListNode n2 = new ListNode(2);
        ListNode n3 = new ListNode(6);
        ListNode n4 = new ListNode(3);
        ListNode n5 = new ListNode(4);
        ListNode n6 = new ListNode(5);
        ListNode n7 = new ListNode(6);

        n1.next = n2;
        n2.next = n3;
        n3.next = n4;
        n4.next = n5;
        n5.next = n6;
        n6.next = n7;
        n7.next = null;
        removeElements(n1, 6);
        while (n1.next != null) {
            System.out.println(n1.val);
            n1 = n1.next;
        }
    }

    public static ListNode removeElements(ListNode head, int val) {
        ListNode header = new ListNode(-1);
        header.next = head;
        ListNode Cur = header;
        while (Cur.next != null) {
            if (Cur.next.val == val) {
                Cur.next = Cur.next.next;
            } else {
                Cur = Cur.next;
            }
        }
        return header.next;
    }


}





