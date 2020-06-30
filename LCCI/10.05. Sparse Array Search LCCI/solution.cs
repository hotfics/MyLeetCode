using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System;
using System.Text;
using System.Net.Http;

namespace a
{
	public class Solution
	{
		
		public static void Main()
		{	
			string[] w = {
				"", "", "", "", "", " dQWlBwMkQGCAH", "", "", "", "", "", "", "", "", " kbmYemYUbb", "", "", "", "", "", "AhdDHirVKcLkr ", "", "", "", "", "", "", "", "", "", "", "", "BNAbUAatDzPXTHQfEhiH", "", "", "", "", "", "BRrrNNUbmm", "", "", "BrluxJYeZ", "", "", "", "", "", "", "", "", "", "", "C", "", "", "", "COZgRwNRaTVH", "", "", "", "", "", "", "", "", "", "COy", "", "", "", "", "", "CZiiiXfgR", "", "", "", "", "", "", "", "", "CvsytGxtr", "", "", "", "", "DYgNOJzvt dKo", "", "", "", "", "", "", "", "", "ETxOvZADWeGZymn", "", "", "", "", "Enw", "", "", "", "", "ErObvXdjyJ", "", "", "", "", "", "", "", "Fxt", "", "", "", "", "", "Hcg", "", "IFCmcsMQZVDw", "", "", "", "", "", "IxwAsjDo", "", "", "", "", "JJRmOfMVv", "", "", "", "", "", "", "", "", "", "KbmELArhbtQloxzJkOZB", "", "", "KmrXslnWHv bviiXljAK", "", "", "", "", "", "KoQgClvxqrOEIM nCY", "", "", "", "", "", "LBZAnpDJskac", "", "LKSy", "", "", "", "", "", "LMCUFc ynZCbTqJRDOIH", "", "", "", "", "", "", "", "", "", "LZui eEOVxOo", "", "", "", "", "", "", "LmeGZUSZgqJ", "", "", "", "MMsARKwsJ", "", "", "My", "", "", "", "NGcuzKOVRNyqDFuE", "", "", "NHEReECTTxUCeElZquZe", "", "", "", "", "OKoDrnWrGZyTYUDS", "", "", "", "", "", "", "", "", "", "OitAuWpxzogGOVGbVqRc", "", "", "", "", "", "", "", "", "OvSVSZYgfaTD", "", "", "PW", "", "", "", "", "", "", "", "", "", "Pf", "", "PmqWrQsrrFVpQe", "", "", "", "", "", "", "", "", "", "QSZxNOguO", "", "", "", "", "QxhpjdwPNUOTj", "", "", "", "", "", "", "", "", "", "R", "", "", "", "", "", "RZZnlbAHKZJH", "", "", "", "", "", "", "RcrNcLvsvCdYCe", "", "", "", "", "", "RunaVcyf", "", "", "SkCZwclZ", "TNawyWMprE", "", "", "", "", "", "", "", "", "TUKi", "TeBcKqVdjVIJtzRy", "", "", "TmGbS GYWH", "", "", "", "", "", "UgjPSTLdQAesaBYVV", "", "", "UnpPgKLLgnHsDRw", "VDHEYbbmcSibGkoOY", "", "", "VFhbWJAydDCFyZvbFA", "", "", "", "", "", "", "", "", "", "", "", "VWQZxHx YvKZgxkScVR", "", "", "", "", "", "WJqaQdZZXBrXXtIWGq", "", "", "WiAdRTHgdJNLKZPrV", "", "", "", "", "", "", "", "", "X", "", "", "", "", "", "", "XgbKyxpd", "", "", "", "XjYPV", "", "", "", "", "", "", "", "YNY UFJJNRMHtA", "", "", "", "", "", "", "", "YeNY", "", "", "", "", "", "", "", "", "", "ZKcuWQvdKD", "", "", "", "ZjjfTUB", "", "", "", "", "", "", "ZxhS", "", "", "", "", "", "", "aNRzbCptSLqKcwHn", "", "", "", "", "", "", "aWTfJvpFLsNzL", "", "", "", "", "", "", "", "", "", "aquRNbNXxsRQwBHVeIWa", "", "", "", "", "", "bsy", "", "", "", "", "", "", "c cxJUciWsLmXZSCIG", "", "", "", "", "", "", "dHGYGGa", "", "", "eBnLl", "", "ffesVvulHsm", "", "", "", "", "", "", "", "", "", "", "", "ggXhLRpAHZYPh", "", "", "", "", "", "", "", "", "", "", "", "gksuHImKFIzbHmQBzksg", "grWcl", "", "", "", "", "", "", "hLwNisMg", "", "", "", "", "", "", "", "", "", "", "htZGqEaqFSsHlDQX", "", "", "", "", "", "", "", "", "", "jGppHHwT", "jd", "", "", "", "", "", "", "", "kWof", "", "", "", "", "", "", "", "kvPEgk", "lDBdeQZRgQNlDIP", "", "", "", "", "", "", "", "", "", "lIceBio", "", "", "", "", "", "", "", "", "", "", "", "mIIIss", "", "", "", "", "", "", "", "", "", "mJKai", "", "", "", "", "muIekSC", "", "nMJipECkkgnEcMmyfob", "", "", "", "", "", "", "", "nXivxaBbI", "q", "", "", "", "", "", "", "", "", "", "qAmqnvNBHnB", "", "", "", "", "", "", "", "", "", "qPOf tD", "", "", "", "", "", "", "", "", "", "qilsrkiifEeOj", "", "", "", "", "", "", "", "", "", "rPfjvzoHWzecujWUoRX", "", "", "", "", "rYf", "", "", "", "", "", "", "", "", "", "", "", "sGUgT PfifYJYdkd", "", "", "", "", "", "", "", "", "", "sf LOmMcRojVEc", "", "tvJQ", "", "", "", "", "uabKCYiiKmmpUns", "", "", "", "", "", "", "", "", "", "", "", "udz", "", "uqSPk OkChjuD", "", "", "", "", "", "", "y", "", "", "", "", "", "yHQWPlWSNwtb", "", "", "", "", "", "", "", "", "", "", "yWfXCUsa", "", "", "", "", "", "", "zEZXmgrvQoOTwOKoEIEd", "", "", "zZEMDDvzsOgTmzc", "", "", "", "", "", "", "", "", "", "", "", "zk", "", "", "", "", "", "", "", "", "znWcoGeFJicW nPjHUGm"
			};
			var s = "kKfytHTqoIrKNCQjzJIF";
			Console.WriteLine(FindString(w, s));
			Console.ReadLine();
		}
		public static int FindString(string[] w, string s)
		{
			int l = w.Length;
			int i = 0;
			int j = l - 1;
			int m = 0;
			while (i <= j) {
				while (w[i] == "" && (i < j)) {
					i++;
				}
				while (w[j] == "" && j > 0) {
					j--;
				}
				m = i + (j - i) / 2;
				while (w[m] == "" && m <= j) {
					m++;
				}
				if (string.Compare(w[m], s, StringComparison.Ordinal) > 0) {
					j = m - 1;
				 
				} else if (string.Compare(w[m], s, StringComparison.Ordinal) < 0) {
					i = m + 1;
					 
				} else {
					return m;
				}
			}
			return -1;
		}
				

	}
	   
}


