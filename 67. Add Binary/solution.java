package com.company;

public class Main {
    public static void main(String[] args) {
        String a = "1010";
        String b = "1011";
        String c = addBinary(a, b);
        System.out.println(c);
    }

    public static String addBinary(String a, String b) {
        int apos = a.length();
        int bpos = b.length();
        int abit;
        int bbit;
        String result = "";
        int carry = 0;
        while (apos > 0 || bpos > 0 || carry > 0) {
            if (apos == 0) abit = 0;
            else
                abit = a.charAt(--apos) == '1' ? 1 : 0;
            if (bpos == 0) bbit = 0;
            else
                bbit = b.charAt(--bpos) == '1' ? 1 : 0;
            result = ((abit ^ bbit ^ carry) > 0 ? "1" : "0") + result;
            carry = (abit + bbit + carry >= 2) ? 1 : 0;
        }
        return result;
    }


}





