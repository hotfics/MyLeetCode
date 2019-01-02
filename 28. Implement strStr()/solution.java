public class Main {

    public static void main(String[] args) {

        int i = strStr("a", "a");
        System.out.println(i);


    }

    public static int strStr(String haystack, String needle) {
        if (needle.length() == 0) return -1;
        if (haystack.contains(needle)) {
            int pos = -1;
            char[] hs = haystack.toCharArray();
            char[] ns = needle.toCharArray();
            for (int i = 0; i < hs.length; i++) {
                if (hs[i] == ns[0]) {
                    pos = i;
                    int tmp = i;
                    for (int j = 0; j < ns.length; j++) {
                        if (hs[tmp] == ns[j]) {
                            tmp++;
                            if (j == ns.length - 1) return pos;
                            else continue;
                        } else {
                            pos = -1;
                            break;
                        }
                    }
                }
            }
        }
        return -1;
    }
}
