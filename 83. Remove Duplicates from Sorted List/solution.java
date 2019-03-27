package com.company;

import java.util.Iterator;
import java.util.Set;
import java.util.TreeSet;

public class Main {
    public static void main(String[] args) {
        ListNode n1 = new ListNode(1);
        ListNode n2 = new ListNode(2);
        ListNode n3 = new ListNode(2);
        ListNode n4 = new ListNode(3);
        n1.next = n2;
        n2.next = n3;
        n3.next = n4;
        n4.next = null;
        ListNode listNode = deleteDuplicates(n1);
        while (listNode != null) {
            System.out.println(listNode.val);
            listNode = listNode.next;
        }
    }

    public static ListNode deleteDuplicates(ListNode head) {
        if (head == null) return head;
        ListNode node = head;
        Set<Integer> set = new TreeSet<>();
        while (head != null) {
            set.add(head.val);
            head = head.next;
        }
        ListNode head1 = node;

        Iterator<Integer> iterator = set.iterator();
        while (iterator.hasNext()) {
            head1.next = new ListNode(iterator.next());
            head1 = head1.next;
        }
        head1.next = null;
        return node.next;

    }


}





