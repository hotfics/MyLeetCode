package com.company;

public class Main {
    public static void main(String[] args) {
        String s="()()";

        String s1="()(";
        String s2="{()}";
        String s3="[{()}";
        String s4="[{]()}";
        String s5="([)]";
        String s6="{}[][]()(){}";
        String s7="";

      System.out.println(isValild(s));
       System.out.println(isValild(s1));
       System.out.println(isValild(s2));
       System.out.println(isValild(s3));
       System.out.println(isValild(s4));
        System.out.println(isValild(s5));
        System.out.println(isValild(s6));
        System.out.println(isValild(s7));
    }
    private static  boolean isValild(String str){
        if ((str.length() % 2 ==1) ||(str.length()==0))
            return false;
        int matchedIndex = 0;

        char rightP='}';
        switch (str.charAt(0))      {
            case '(':
                rightP=')';
                break;
            case '[':
                rightP=']';
                break;
            case '{':
                rightP='}';
                break;
        }
        for (int i=1;i<str.length();i++){
           if(rightP==str.charAt(i)){
               matchedIndex=i;
               if (matchedIndex==1){}
               else
                   return false;
               break;
           }
        }
        String s1=str.substring(0,matchedIndex);
        String s2=str.substring(matchedIndex+1,str.length());
        String s=s1+s2;
        String sFinal=s.substring(1,s.length());
        if (sFinal.length()==0)
            return true;
        else
            return isValild(sFinal);
    }
}

