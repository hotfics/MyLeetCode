using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args1)
        {
            var p = "abba";
            var s = "dog dog dog dog";
            var v = WordPattern(p, s);
            Console.WriteLine(v);
        }
        public static bool WordPattern(string pattern, string str)
        {

            var ss = str.Split(' ');
            int l = ss.Length;
            if (pattern.Length != l)
            {
                return false;
            }
            else
            {
                var map = new Dictionary<string, string>();
                for (int i = 0; i < pattern.Length; i++)
                {
                    var key = pattern[i].ToString();
                    var value = ss[i];
                    if (!map.ContainsKey(key))
                    {
                        var oldkey = (from q in map where q.Value == value select q.Key).ToList();
                        if (oldkey.Any())
                            return false;
                        map.Add(key, value);
                    }
                    else
                    {
                        var t = "";
                        map.TryGetValue(key, out t);
                        if (t != value)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
