package com.company;

import java.util.*;
import java.util.stream.Stream;

public class Main {


    public static void main(String[] args) {
        int nums[] = {1, 2, 3, 1, 2, 3};
        boolean b = containsNearbyDuplicate(nums, 2);
        System.out.println(b);
    }

    public static boolean containsNearbyDuplicate(int[] nums, int k) {
        for (int i = 0; i < nums.length; i++) {
            for (int j = i + 1; j < nums.length; j++) {
                if ((j - i) <= k) {
                    if (nums[j] == nums[i]) return true;
                } else {
                    break;
                }
            }
        }
        return false;
    }

}






