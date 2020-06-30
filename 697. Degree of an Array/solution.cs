using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args1)
        {
    
            int[] n = { 1, 2, 2, 3, 1 };
            FindShortestSubArray(n);
        }
        public static int FindShortestSubArray(int[] nums)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]]++;
                }
                else
                {
                    map.Add(nums[i], 1);
                }
            }
            KeyValuePair<int, int> kv = new KeyValuePair<int, int>(-1, 0);
            foreach (var kp in map)
            {
                if (kp.Value > kv.Value)
                {
                    kv = kp;
                }
            }
            var matchs = from p in map where p.Value == kv.Value select p;
            int min = int.MaxValue;
            foreach (var m in matchs)
            {
                int i = nums.ToList().FindIndex(x => x == m.Key);
                int j = nums.ToList().FindLastIndex(x => x == m.Key);
                int diff = j - i;
                if (diff < min)
                {
                    min = diff;
                }
            }
            return min+1;

        }

     
        
    }
}
