package com.company;
public class Main {
    public static void main(String[] args) {
        int len = lengthOfLongestSubstring("abc");
        int len1 = lengthOfLongestSubstring("bbb");
        int len2 = lengthOfLongestSubstring("abcbbbddd");
        System.out.println(len);
        System.out.println(len1);
        System.out.println(len2);
    }

    public static int lengthOfLongestSubstring(String s) {
        if (s.length() == 1) return 1;
        if (s == null) return 0;
        char[] chars = s.toCharArray();
        int max = 0;
        int k = 0;
        for (int i = 0; i < chars.length; i++) {
            for (int j = k; j < i; j++) {
                if (chars[i] == chars[j]) {
                    k = j + 1;
                    break;
                }
            }
            int cur_maxLen = i - k + 1;
            if (cur_maxLen > max)
                max = cur_maxLen;
        }
        return max;
    }
}










