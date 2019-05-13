package com.company;

import java.util.*;
import java.util.stream.Collectors;

import static java.util.Arrays.stream;

public class Main {
    public static void main(String[] args) {
        int[] nums = {};
        List<List<Integer>> lists = permute(nums);
        for (List<Integer> list : lists) {
            list.stream().forEach(x -> System.out.print(x + " "));
            System.out.println("-----");
        }
    }

    public static List<List<Integer>> permute(int[] nums) {
        List<List<Integer>> lists = new ArrayList<>();
        permuteCore(lists, nums, 0);
        return lists;
    }

    private static void permuteCore(List<List<Integer>> result, int[] nums, int begin) {
        if (nums.length - 1 == begin) {
            List<Integer> listInt = Arrays.stream(nums).boxed().collect(Collectors.toList());
            result.add(listInt);
        }
        for (int i = begin; i < nums.length; i++) {
            swap(nums, i, begin);
            permuteCore(result, nums, begin + 1);
            swap(nums, begin, i);
        }
    }

    private static void swap(int[] nums, int j, int k) {
        int temp = nums[j];
        nums[j] = nums[k];
        nums[k] = temp;

    }
}










