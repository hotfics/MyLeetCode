package com.company;

public class Main {
    public static void main(String[] args) {
        System.out.println(findTheDifference("cbad", "abecd"));
    }

    public static char findTheDifference(String s, String t) {
        char[] cs = s.toCharArray();
        char[] ct = t.toCharArray();
        int[] ints = new int[cs.length];
        int[] intt = new int[ct.length];
        int a = 0;
        int b = 0;
        for (int i = 0; i < cs.length; i++) {
            ints[i] = cs[i];
        }
        for (int i = 0; i < ct.length; i++) {
            intt[i] = ct[i];
        }
        for (int i = 0; i < ints.length; i++) {
            a ^= ints[i];
        }
        for (int i = 0; i < intt.length; i++) {

            b ^= intt[i];
        }
        a = a ^ b;
        char c = (char) a;
        return c;
    }
}





