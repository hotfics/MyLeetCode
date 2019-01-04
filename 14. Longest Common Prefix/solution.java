class Solution {
    public String longestCommonPrefix(String[] strs) {
          if (strs.length==0) return "";
          for (String s : strs) {
            if (s.length() == 0) return "";
        }
        StringBuffer sb = new StringBuffer();
        int min = minStringLength(strs);
        int j = min;
        while (j >= 0) {
            int count = 0;
            for (int i = 0; i < strs.length; i++) {
                sb.append(strs[i].substring(0, j));
            }
            if (validComString(sb.toString(), strs)) {
                return minString(strs).substring(0, j);
            } else {
                sb.delete(0, sb.length());
                j--;
            }
        }
        return "";
    }
       private  String minString(String[] strs) {
        for (String s : strs) {
            if (s.length() == minStringLength(strs))
                return s;
        }
        return "";
    }
    private static int minStringLength(String[] strs) {
        int min = Integer.MAX_VALUE;
        for (int i = 0; i < strs.length; i++) {
            if (strs[i].length() < min) min = strs[i].length();
        }
        return min;
    }
       private static boolean validComString(String _s, String[] strs) {
        String[] comParts = new String[strs.length];
        int step=_s.length() / strs.length;
        for (int i = 0; i < comParts.length; i++) {
            comParts[i] = _s.substring(i*step, step*i+step);
        }
        for (int j = 0; j < comParts.length; j++) {
            if (!comParts[j].equals(comParts[0])) {
                return false;
            }
        }
        return true;
    }
}