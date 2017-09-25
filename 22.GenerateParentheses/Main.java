import java.util.ArrayList;
import java.util.List;

public class Main {
    public static List<String> generateParenthesis(int n) {
        List<String> lstr = new ArrayList<>();
        addParenthesis(n, 0, "", lstr);
        return lstr;

    }

    public static void addParenthesis(int l, int r, String str, List<String> result) {
        if ((l == 0) && (r == 0)) result.add(str);
        if (l > 0) addParenthesis(l - 1, r + 1, str + "(", result);
        if (r > 0) addParenthesis(l, r - 1, str + ")", result);
    }

    public static void main(String[] args) {
        List<String> lst = generateParenthesis(5);
        for (String s :
                lst) {
            System.out.println(s);
        }
    }
}
