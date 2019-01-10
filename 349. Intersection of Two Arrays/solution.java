package com.company;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        int[] array = {2, 1};
        int[] a = {4, 9, 5};
        int[] b = {9, 4, 9, 8, 4};
        int[] c = intersection(a, b);
        for (int i : c) {
            System.out.println(i);
        }
    }
    public static int[] intersection(int[] nums1, int[] nums2) {
        Set<Integer> set1 = new HashSet<>();
        Set<Integer> set2 = new HashSet<>();
        for (Integer i : nums1) set1.add(i);
        for (Integer j : nums2) set2.add(j);
        int lenA = set1.size();
        int lenB = set2.size();
        int len = lenA < lenB ? lenA : lenB;
        Integer[] a = new Integer[set1.size()];
        set1.toArray(a);
        Integer[] b = new Integer[set2.size()];
        set2.toArray(b);
        List<Integer> result = new ArrayList<>();
        if (lenA < lenB) {
            for (int i = 0; i < lenA; i++) {
                if (arrayContains(b, a[i])) {
                    result.add(a[i]);
                }
            }
        } else {
            for (int i = 0; i < lenB; i++) {
                if (arrayContains(a, b[i])) {
                    result.add(b[i]);
                }
            }
        }
        int[] resultArr = new int[result.size()];
        for (int i = 0; i < result.size(); i++) {
            resultArr[i] = result.get(i);
        }
        return resultArr;
    }
    private static boolean arrayContains(Integer[] array, int value) {
        for (Integer i : array) {
            if (i.equals(value)) {
                return true;
            }
        }
        return false;
    }


}





