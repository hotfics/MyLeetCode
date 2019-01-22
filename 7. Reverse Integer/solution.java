package com.company;

public class Main {
    public static void main(String[] args) {
        String s = "-021";
        int a = Integer.valueOf(s);
        int re = reverse(-2147483648);
        System.out.println(re);
    }
    public static int reverse(int x) {
        if (x == 0) return 0;
        String s = "";
        if (x > 0) {
            s = Integer.valueOf(x).toString();
            String reversed = reverseString(s);
            long result = Long.valueOf(reversed);
            if (result > Integer.MAX_VALUE) return 0;
            else return (int) result;
        } else {
            if (x == -2147483648) //2^31
            {
                s = "2147483648";
            } else {
                s = Integer.valueOf(Math.abs(x)).toString();
            }
            String reversed = reverseString(s);
            long result = Long.valueOf(reversed);
            if (result > Integer.MAX_VALUE) return 0;
            else return (int) result * (-1);
        }
    }

    private static String reverseString(String str) {
        StringBuilder sb = new StringBuilder(str);
        sb.reverse();
        return sb.toString();
    }


}





