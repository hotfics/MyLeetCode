package com.company;

public class Main {
    public static void main(String[] args) {
        boolean a = isPowerOfFour(1);
        boolean b = isPowerOfFour(45);
        System.out.println(a);
        System.out.println(b);
    }
    public  static  boolean isPowerOfFour(int num) {
        if (num == 1) return true;
        if (num % 4 != 0) return false;
        for (int i = 0; i < 20; i++) {
            int value = (int) Math.pow(4, i);
            if (value > Integer.MAX_VALUE) return false;
            if (value == num) return true;
        }
        return false;
    }
}

