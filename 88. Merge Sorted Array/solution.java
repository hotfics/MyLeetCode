package com.company;

import java.util.*;
import java.util.stream.Stream;
public class Main {
    public static void main(String[] args) {
        int[] n1 = {1, 2, 3, 0, 0, 0};
        int[] n2 = {2, 5, 6};
        merge(n1, 3, n2, 3);
        Arrays.stream(n1).forEach(x -> System.out.println(x));
    }
    public static void merge(int[] nums1, int m, int[] nums2, int n) {
        List<Integer> list = new ArrayList<>();
        for (int i = 0; i < m; i++) {
            list.add(nums1[i]);
        }
        for (int j = 0; j < n; j++) {
            list.add(nums2[j]);
        }
        Collections.sort(list);
        for (int k = 0; k < list.size(); k++) {
            nums1[k] = list.get(k);
        }
    }
}






