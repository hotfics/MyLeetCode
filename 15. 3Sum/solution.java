package com.company;

import java.util.*;
public class Main {
    public static void main(String[] args) {
        int[] nums = {3, 0, -2, -1, 1, 2};
        List<List<Integer>> lists = threeSum(nums);
        for (List<Integer> list : lists) {
            list.stream().forEach(x -> System.out.print(x + " "));
            System.out.println();
        }
    }
    public static List<List<Integer>> threeSum(int[] nums) {
        if (nums.length < 3) return new ArrayList<>();
        if (!Arrays.stream(nums).anyMatch(x -> x != 0)) {
            List<Integer> list = new ArrayList<>();
            list.add(0);
            list.add(0);
            list.add(0);
            List<List<Integer>> lists = new ArrayList<>();
            lists.add(list);
            return lists;
        }
        Set<List<Integer>> set = new HashSet<>();
        Arrays.sort(nums);
        for (int i = 0; i < nums.length; i++) {
            int j = i + 1;
            int k = nums.length - 1;
            int sumThree = 0;
            while (j < k) {
                sumThree = nums[i] + nums[j] + nums[k];
                if (sumThree == 0) {
                    List<Integer> integerList = new ArrayList<>();
                    integerList.add(nums[i]);
                    integerList.add(nums[j]);
                    integerList.add(nums[k]);
                    set.add(integerList);
                    j++;
                } else if (sumThree > 0) {
                    k--;
                } else {
                    j++;
                }
            }
        }
        return new ArrayList<List<Integer>>(set);
    }
}










