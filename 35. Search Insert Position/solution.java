package com.company;

public class Main {
    public static void main(String[] args) {


    }

    public static int searchInsert(int[] nums, int target) {
        if (target < nums[0]) return 0;
        if (target > nums[nums.length - 1]) return nums.length;
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == target) {
                return i;
            } else {
                if (nums[i] < target && nums[i + 1] > target) {
                    return i + 1;
                }
            }
        }
        return 0;
    }


}





