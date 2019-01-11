package com.company;
public class Main {
    public static void main(String[] args) {
        int[] nums = {2, 7, 11, 15};
        int[] c = twoSum(nums, 13);
        for (int i : c)
            System.out.println(i);
    }
    public static int[] twoSum(int[] nums, int target) {
        for (int i = 0; i < nums.length; i++) {
            for (int j = 0; j < nums.length; j++) {
                if (j != i) {
                    if (nums[i] + nums[j] == target) {
                        int[] result = new int[2];
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
        }
        return null;
    }
}





