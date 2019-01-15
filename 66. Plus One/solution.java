package com.company;

import java.math.BigInteger;
import java.util.*;
public class Main {
    public static void main(String[] args) {
        int[] digits = {9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
        plusOne(digits);
    }

    public static int[] plusOne(int[] digits) {
        BigInteger num = new BigInteger("0");
        String s = "";
        StringBuffer sb = new StringBuffer();
        for (int d : digits) {
            sb.append(d);
        }
        s = sb.toString();
        num = num.add(new BigInteger(s));
        num = num.add(new BigInteger("1"));
        Stack<Integer> stack = new Stack<>();
        int c = 0;
        while (num.compareTo(new BigInteger("0")) == 1) {
            int n = num.remainder(new BigInteger("10")).intValueExact();
            stack.push(n);
            num = num.divide(new BigInteger("10"));
          //  System.out.println(num);
        }
        int size = stack.size();
        int[] result = new int[stack.size()];
        for (int i = 0; i < size; i++) {
            result[i] = stack.pop();
        }
//        for (int i : result) {
//            System.out.println(i);
//        }
        return result;
    }


}





