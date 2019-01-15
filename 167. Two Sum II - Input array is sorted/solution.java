package com.company;

public class Main {
    public static void main(String[] args) {
        //  int[] digits = {3,24,50,79,88,150,345};
        //   int[] digits = {2,3,4};
        int[] digits = {1, 2, 3, 4, 4, 9, 56, 90};
        // int c =binarySearch(digits,0,digits.length-1,2,50,200);
        int c = binarySearch(digits, 0, digits.length - 1, 3, 4, 8);
        System.out.println(c);
        twoSum(digits, 9);
    }
    public static int[] twoSum(int[] numbers, int target) {
        int lowIndex = 0;
        int[] result = new int[2];
        int len = numbers.length;
        for (int i = 0; i < numbers.length; i++) {
            int searchedIndex = binarySearch(numbers, 0, len - 1, i, numbers[i], target);
            if (searchedIndex != -1) {
                result[0] = ++i;
                result[1] = ++searchedIndex;
                break;
            }
        }
        return result;
    }
    private static int binarySearch(int[] nums, int low, int high, int lowindex, int val, int target) {
        int mid = 0;
        while (low < high) {
            mid = low + (high - low) / 2;
            if (nums[mid] + val > target) {
                high = mid;
            } else if (nums[mid] + val < target) {
                low = mid + 1;
            } else {
                if (mid != lowindex) {
                    return mid;
                } else {
                    low = mid + 1;
                }
            }
        }
        if ((nums[low] + val == target) && (low != lowindex)) return low;
        return -1;
    }
}





