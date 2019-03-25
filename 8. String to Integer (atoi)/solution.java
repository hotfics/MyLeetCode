package com.company;

public class Main {
    public static void main(String[] args) {
        int a = myAtoi("   -42");
        System.out.println(a);
    }

    public static int myAtoi(String str) {
        if (str == null || (str = str.trim()).length() == 0) return 0;
        char c = str.charAt(0);
        if (Character.isDigit(c) == false) {
            if (str.charAt(0) != '+' && str.charAt(0) != '-') {
                return 0;
            }
        }
        int sign = 1;
        long result = 0;
        int index = 0;
        if (c == '-' || c == '+') {
            sign = c == '-' ? -1 : 1;
            index = 1;
        }
        for (; index < str.length(); index++) {
            if (Character.isDigit(str.charAt(index))) {
                result = result * 10 + (str.charAt(index) - '0');
                if (result > Integer.MAX_VALUE)
                    break;
                continue;
            }
            break;
        }
        result = result * sign;
        return result >= Integer.MAX_VALUE ? Integer.MAX_VALUE : (int) Math.max(result, Integer.MIN_VALUE);
    }

}





