package com.company;

import java.util.*;

public class Main {
    static class CharactorValue {
        public CharactorValue(char c, int i) {
            _char = c;
            value = i;
        }

        public Character get_char() {
            return _char;
        }

        public void set_char(Character _char) {
            this._char = _char;
        }

        public int getValue() {
            return value;
        }

        public void setValue(int value) {
            this.value = value;
        }

        public Character _char;
        public int value;
    }

    public static void main(String[] args) {
        String s = countAndSay(7);
        System.out.println(s);
    }

    public static String countAndSay(int n) {

        if (n == 1) return "1";
        if (n == 2) return "11";
        if (n == 3) return "21";
        if (n == 4) return "1211";
        String result = "1211";
        int count = 4;

        while (count < n) {

            result = speak(count(result));
            count++;
        }
        return result;
    }

    private static List<CharactorValue> count(String s) {

        char[] chars = s.toCharArray();
        List<CharactorValue> list = new ArrayList<>();
        if (s.equals("1211")) {
            list.add(new CharactorValue('1', 1));
            list.add(new CharactorValue('2', 1));
            list.add(new CharactorValue('1', 2));
            return list;
        }
        int num = 0;
        char c = s.charAt(0);
        for (int i = 0; i < s.length(); i++) {
            if (c == s.charAt(i)) {
                num++;
            } else {
                list.add(new CharactorValue(chars[i - 1], num));
                c = s.charAt(i);
                i--;
                num = 0;
            }
            if (i == s.length() - 1) {
                if (num > 0)
                    list.add(new CharactorValue(chars[i], num));
            }
        }

        return list;
    }

    private static String speak(List<CharactorValue> list) {
        StringBuilder sb = new StringBuilder();
        for (CharactorValue entry : list) {
            sb.append(entry.getValue());
            sb.append(entry.get_char());
        }
        return sb.toString();
    }


}





