package com.company;
import java.util.*;

public class Main {
    public static void main(String[] args) {

        boolean c = isHappy(7);
        System.out.println(c);
    }

    public static boolean isHappy(int n) {
        Stack<Integer> stack = new Stack<>();
        List<Integer> list = new ArrayList<>();
        while (n != 1) {
            list.add(n);
            boolean flag = hasSameNum(list);
            if (flag) return false;
            int num = 0;
            while (n % 10 != n) {
                int n1 = n % 10;
                stack.push(n1);
                n = n / 10;
            }
            stack.push(n);

            while (stack.size() > 0) {
                int p = 0;
                int i = stack.peek();
                num += i * i;
                stack.pop();
            }

            n = num;

        }
        return true;

    }

    private static boolean hasSameNum(List<Integer> list) {
        if (list.size() == 1) return false;
        Set<Integer> set = new HashSet<>();
        for (int i = 0; i < list.size(); i++) {
            set.add(list.get(i));
        }
        if (list.size() > set.size())
            return true;
        else
            return false;

    }


}





