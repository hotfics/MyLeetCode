package com.company;

import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        int[] nums = {2, 0, 2, 1, 1, 0};
        sortColors(nums);
        for (int i : nums) {
            System.out.println(i);
        }
    }

    public static void sortColors(int[] nums) {
        long oneCount = Arrays.stream(nums).filter(x -> x == 1).count();
        long twoCount = Arrays.stream(nums).filter(x -> x == 2).count();
        long zeroCount = Arrays.stream(nums).filter(x -> x == 0).count();
        int i = 0;
        while (zeroCount > 0) {
            nums[i++] = 0;
            zeroCount = zeroCount - 1;
        }
        while (oneCount > 0) {
            nums[i++] = 1;
            oneCount = oneCount - 1;
        }
        while (twoCount > 0) {
            nums[i++] = 2;
            twoCount = twoCount - 1;
        }
    }
}





