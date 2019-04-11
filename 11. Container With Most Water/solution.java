package com.company;

import java.util.*;

public class Main {

    public static void main(String[] args) {
        int[] a = {1, 8, 6, 2, 5, 4, 8, 3, 7};
        int area = maxArea(a);
        System.out.println(area);
    }
    public static int maxArea(int[] height) {
        int maxArea = 0;
        for (int i = 0; i <= height.length - 1; i++) {
            for (int j = i + 1; j <= height.length - 1; j++) {
                int realHeight = 0;
                if (height[i] <= height[j]) realHeight = height[i];
                else realHeight = height[j];
                int area = realHeight * (j - i);
                if (area > maxArea)
                    maxArea = area;
            }
        }
        return maxArea;
    }
}










