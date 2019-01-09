package com.company;
public class Main {
    public static void main(String[] args) {
        int n=addDigits(38);
        System.out.println(n);
    }
    public static int addDigits(int num) {
        if (num<10) return num;
        int result=0;
        while (num>=10){
            result+= num % 10;
            num=num/10;
        }
        return addDigits(  result+num);
    }
}

