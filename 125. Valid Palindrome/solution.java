package com.company;

public class Main {

    public static void main(String[] args) {
        String s="race a car";
        String s1="A man, a plan, a canal: Panama";
        boolean a= isPalindrome(s);
       boolean b= isPalindrome(s1);
       System.out.println(a);
        System.out.println(b);
    }

    public static boolean isPalindrome(String s) {
        String _s=filter(s);
        char[] chars=_s.toCharArray();
        for (int i=0;i<chars.length-1-i;i++){
            if (chars[i]!=chars[chars.length-1-i]){
                return false;
            }
        }
        return true;
    }
    private  static  String filter(String s){
        char[] chars=s.trim().toLowerCase().toCharArray();
        StringBuffer s1=new StringBuffer();
        for (int i=0;i<chars.length;i++){
            if (Character.isAlphabetic(chars[i]) || Character.isDigit(chars[i])){
                s1.append(chars[i]);
            }
        }
        return s1.toString();
    }
}
