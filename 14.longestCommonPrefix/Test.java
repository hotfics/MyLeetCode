
package commonfix;
//Write a function to find the longest common prefix string amongst an array of strings.


public class Solution {
	public static String longestCommonPrefix(String[] strs) {
		String result = "";
		for (int i = 0; i < strs[0].length(); i++) {
			char c = strs[0].charAt(i);
			for (int j = 1; j < strs.length; j++) {
				
				if ((i >= strs[j].length()) || (c != strs[j].charAt(i))) {
					return result;
				}
			}
			result += Character.toString(c);

		}
		return result;
	}

	public static void main(String[] args) {
		String[] strs = { "ab", "absafasdfas", "abcasdf", "abc" };
		String string = longestCommonPrefix(strs);
		System.out.println(string);
	}
}
