import javax.xml.ws.Holder;

public class re {
    public static void main(String[] args) {
        String s = "cbbd";
        //  String s = "babad";
        String s1 = longestPalindrome(s);
        System.out.println(s1);
    }

    public static String longestPalindrome(String s) {
        int size = s.length();
        if (size < 2) return s;
        Holder<Integer> maxLen = new Holder<>(0);
        Holder<Integer> start = new Holder<>(0);
        for (int i = 0; i < size - 1; i++) {
            searchPalindrome(s, i, i, start, maxLen);
            searchPalindrome(s, i, i + 1, start, maxLen);
        }
        return s.substring(start.value, maxLen.value + start.value);
    }

    private static void searchPalindrome(String s, int left, int right, Holder<Integer> start, Holder<Integer> maxLen) {
        int size = s.length();
        while (left >= 0 && right < size && s.charAt(left) == s.charAt(right)) {
            left--;
            right++;
        }
        if (maxLen.value < right - left - 1) {
            start.value = left + 1;
            maxLen.value = right - left - 1;
        }
    }
}
x`