package com.company;

public class Main {
    public static void main(String[] args) {
        boolean a = isUgly(8);
        boolean b = isUgly(14);
        System.out.println(a);
        System.out.println(b);
    }
    public static boolean isUgly(int num) {
        if (num <= 0) return false;
        if (num == 1) return true;
        if ((num % 3 != 0) && (num % 5 != 0) && (num % 2 != 0)) return false;
        while (num > 1) {
            if (num % 2 == 0) num = num / 2;
            if (num % 3 == 0) num = num / 3;
            if (num % 5 == 0) num = num / 5;
            if (num == 1) return true;
            if ((num % 3 != 0) && (num % 5 != 0) && (num % 2 != 0)) return false;
        }
        return true;
    }


}

