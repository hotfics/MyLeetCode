package com.company;

import java.util.*;
public class Main {
    public static void main(String[] args) {
        String s = "Let's take LeetCode contest";
        String ss = reverseWords(s);
        System.out.println(ss);
    }
    private static String reverseWords(String s) {
        if (s == null) return null;
        String[] strings = s.split("\\s");
        StringBuilder sb = new StringBuilder();
        for (String str : strings) {

            sb.append(reverseSingleWord(str)).append(" ");
        }
        return sb.toString().trim();
    }
    private static String reverseSingleWord(String string) {
        char[] s = string.toCharArray();
        int A = 0;
        int B = s.length - 1;
        while (A < B) {
            char tmp = s[A];
            s[A] = s[B];
            s[B] = tmp;
            A++;
            B--;
        }
        return new String(s);
    }
}










