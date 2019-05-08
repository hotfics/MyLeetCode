package com.company;

public class Main {
    static class div_t {
        public div_t(int x, int y) {
            this.quot = x;
            this.rem = y;
        }

        public int getQuot() {
            return quot;
        }

        public void setQuot(int quot) {
            this.quot = quot;
        }

        public int getRem() {
            return rem;
        }

        public void setRem(int rem) {
            this.rem = rem;
        }

        public int quot;
        public int rem;
    }

    public static void main(String[] args) {
        ListNode n1 = new ListNode(2);
        ListNode n2 = new ListNode(4);
        ListNode n3 = new ListNode(3);
        n1.next = n2;
        n2.next = n3;
        n3.next = null;
        ListNode n4 = new ListNode(5);
        ListNode n5 = new ListNode(6);
        ListNode n6 = new ListNode(4);
        n4.next = n5;
        n5.next = n6;
        n6.next = null;
        ListNode n7 = new ListNode(5);
        ListNode n8 = new ListNode(5);
        ListNode n = addTwoNumbers(n7, n8);
        while (n != null) {
            System.out.println(n.val);
            n = n.next;
        }
    }

    public static ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;
        div_t divT = new div_t(0, 0);
        for (; l1 != null || l2 != null || divT.quot != 0; tail = tail.next) {
            if (l1 != null) {
                divT.quot += l1.val;
                l1 = l1.next;
            }
            if (l2 != null) {
                divT.quot += l2.val;
                l2 = l2.next;
            }
            divT = div(divT.quot);
            tail.next = new ListNode(divT.rem);
        }
        return dummy.next;
    }

    private static div_t div(int num) {
        div_t divT = new div_t(0, 0);
        divT.setQuot(num / 10);
        divT.setRem(num % 10);
        return divT;
    }
}










