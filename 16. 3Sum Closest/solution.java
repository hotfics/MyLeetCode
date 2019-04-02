package com.company;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        int[] n = {1, 2, 4, 8, 16, 32, 64, 128};
        int value = threeSumClosest(n, 82);
        System.out.println(value);
    }

    public static int threeSumClosest(int[] nums, int target) {
        if (nums.length < 3) return 0;
        Arrays.sort(nums);
        int result = nums[0] + nums[1] + nums[2];
        for (int i = 0; i < nums.length; i++) {
            int j = i + 1;
            int k = nums.length - 1;
            while (j < k) {
                int sum = nums[i] + nums[j] + nums[k];
                if (sum == target) {
                    return target;
                } else {
                    if (Math.abs(result - target) > Math.abs(sum - target)) {
                        result = sum;
                    }
                    if (sum > target)
                        k--;
                    else
                        j++;
                }
            }
        }
        return result;
    }
}







