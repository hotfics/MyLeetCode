package com.company;
public class Main {
    public static void main(String[] args) {
        // System.out.println(isPerfectSquare(9));
        //  System.out.println(isPerfectSquare(120));
        System.out.println(isPerfectSquare(2147395600));
    }
    public static boolean isPerfectSquare(int num) {
        if (num == 0 || num == 1) return true;
        long factor = num / 2;
        while (factor * factor < 0 || factor * factor > num) {
            factor = factor / 2;
        }
        while (factor * factor < num && (factor * factor > 0)) {
            factor = factor + 1;
        }
        if (factor * factor == num) return true;

        return false;

    }
}





