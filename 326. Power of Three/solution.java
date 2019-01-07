package com.company;

public class Main {
    public static void main(String[] args) {
        boolean a = isPowerOfThree(81);
        boolean b = isPowerOfThree(45);
        System.out.println(a);
        System.out.println(b);
    }

    public static final int[] nums = {3,
            (int) Math.pow(3, 2),
            (int) Math.pow(3, 3),
            (int) Math.pow(3, 4),
            (int) Math.pow(3, 5),
            (int) Math.pow(3, 6),
            (int) Math.pow(3, 7),
            (int) Math.pow(3, 8),
            (int) Math.pow(3, 9),
            (int) Math.pow(3, 10),
            (int) Math.pow(3, 11),
            (int) Math.pow(3, 12),
            (int) Math.pow(3, 13),
            (int) Math.pow(3, 14),
            (int) Math.pow(3, 15),
            (int) Math.pow(3, 16),
            (int) Math.pow(3, 17),
            (int) Math.pow(3, 18),
            (int) Math.pow(3, 19),
            (int) Math.pow(3, 20),
    };

    public static boolean isPowerOfThree(int n) {
        if (n == 1) return true;
        if (n % 3 != 0) return false;
        if (n == 3) return true;
        for (int i = nums.length - 1; i >= 0; i--) {
            if (n % nums[i] != n) {
                if (n == nums[i]) return true;
                if (n / nums[i] == 1) {
                    return isPowerOfThree(n / 3);
                }
                return isPowerOfThree(n / nums[i]);
            }
        }
        return false;
    }
}
