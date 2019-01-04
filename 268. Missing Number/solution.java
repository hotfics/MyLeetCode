package com.company;
public class Main {
    public static void main(String[] args) {
        int[] nums = {9, 6, 4, 2, 3, 5, 7, 0, 1};
        int a = missingNumber(nums);
        System.out.println(a);
    }
    private static int missingNumber(int[] nums) {
        int result = 0;
        for (int i = 0; i < nums.length; i++) {
            result = result ^ nums[i];
        }
        for (int j = 0; j <= nums.length; j++) {
            result = result ^ j;
        }
        return result;
    }
}
