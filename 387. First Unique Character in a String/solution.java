package com.company;
import java.util.HashMap;
import java.util.Map;

public class Main {
    public static void main(String[] args) {
        int a=firstUniqChar("dddccdbba");
        System.out.println(a);
    }

    public static int firstUniqChar(String s) {
        int result = -1;
        Map<Character, Integer> map = new HashMap<>();
        char[] chars = s.toCharArray();
        for (int i = 0; i < chars.length; i++) {
            int k = map.containsKey(chars[i]) ? 1 : 0;
            map.put(chars[i], k + 1);
        }
        for (int j = 0; j < chars.length; j++) {
            if ((map.get(chars[j]) == 1)) {
                if (allBiggerThanZero(chars, map)) {
                    return -1;
                } else {
                    result = j;
                    break;

                }
            }
        }
        return result;
    }
    private static boolean allBiggerThanZero(char[] cs, Map<Character, Integer> map) {
        for (int i = 0; i < cs.length; i++) {
            if (map.get(cs[i]) > 1) {}
            else {return  false;}
        }
        return true;
    }


}

