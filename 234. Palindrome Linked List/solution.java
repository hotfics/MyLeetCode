package com.company;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        ListNode n1 = new ListNode(-129);
        ListNode n2 = new ListNode(-129);
        n1.next = n2;
        n2.next = null;
        boolean b3 = isPalindrome(n1);
        System.out.println(b3);
    }

    public static boolean isPalindrome(ListNode head) {
        if (head == null) return true;
        List<Integer> list = new ArrayList<>();
        while (head.next != null) {
            list.add(head.val);
            head = head.next;
        }
        list.add(head.val);
        return isPalindromeString(list);
    }
    static boolean isPalindromeString(List<Integer> s) {

        for (int i = 0; i < s.size(); i++) {
            if (i <= s.size() - i - 1) {
                if (!s.get(i).equals(s.get(s.size() - i - 1))) return false;
            } else {
                break;
            }
        }
        return true;
    }


}

