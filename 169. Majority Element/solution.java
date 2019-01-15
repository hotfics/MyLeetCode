package com.company;

import java.util.*;

public class Main {


    public static void main(String[] args) {
        int[] nums={3,2,3};
        int m= majorityElement(nums);
        System.out.println(m);

    }
    public static int majorityElement(int[] nums) {
        Set<Integer> set=new HashSet<>();
        for (int i=0;i<nums.length;i++){
            set.add(nums[i]);
        }
        for(int s:set){
            long n= Arrays.stream(nums).filter(x->x==s).count();
            if (n>nums.length/2) return s;
        }

        return 0;

    }


}





