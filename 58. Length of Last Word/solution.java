package com.company;

public class Main {
    public static void main(String[] args) {

    }

    public static int lengthOfLastWord(String s) {
        if (s.length() == 0) return 0;
        if (s.trim().length() == 0) return 0;
        String[] ss = s.split(" ");
        return ss[ss.length - 1].length();

    }

}





