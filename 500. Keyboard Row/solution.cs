public class Solution {
   public   string[] FindWords(string[] words)
	{
		var list = new List<string>();
		string[] ss = {
			"qwertyuiopQWERTYUIOP",
			"ASDFGHJKLasdfghjkl",
			"zxcvbnmZXCVBNM"
		};
		foreach (var word in words) {
			string _word = word;
			if (word == null) {
				continue;
			} else {
				int index =	findIndex(word[0]);
				var s = ss[index];
				foreach (var c in s) {
					var oldLen=_word.Length;
					if ( oldLen> 0) {
						_word = _word.Replace(c.ToString(), "");						 
					}					
				}	
				if (_word.Length == 0) {
					list.Add(word);
				}
			}
		}
		return list.ToArray();
	}
	public   int findIndex(char c)
	{
		string[] ss = {
			"qwertyuiopQWERTYUIOP",
			"ASDFGHJKLasdfghjkl",
			"zxcvbnmZXCVBNM"
		};
		for (int i = 0; i < 3; i++) {
			if (ss[i].IndexOf(c) != -1) {
				return i;
			}
		}
		return -1;
	}
}