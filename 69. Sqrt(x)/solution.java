package com.company;

public class Main {
    public static void main(String[] args) {
        int a = mySqrt(6);
        System.out.println(a);
    }
    public static int mySqrt(int x) {
        if (x < 2) return x;
        long r = x;
        while (r > x / r) {
            r = (r + x / r) / 2;
        }
        return (int) r;
    }

}





