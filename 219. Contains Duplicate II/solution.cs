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
            int[] n = { 99, 99 };        
            var b = ContainsNearbyDuplicate(n, 3);
            Console.WriteLine(b);
            Console.ReadLine();
        }
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var map = new Dictionary<int,List<int>>();
            for (int i = 0; i < nums.Length; i++) {
                List<int> list = new List<int>();
                
                if (!map.ContainsKey(nums[i])) {
                    list.Add(i);
                    map.Add(nums[i], list);
                } else {
                    var listT = new List<int>();
                    map.TryGetValue(nums[i], out list);
                    list.Add(i);
                }
            }
            foreach (var kp in map) {
                var vList = kp.Value;
                for (int i = 0; i < vList.Count; i++) {
                    for (int j = i + 1; j < vList.Count; j++) {
                        var diffValue = Math.Abs((vList[i] - vList[j]));
                        if (diffValue <= k) {
                            return true;
                        } else if (diffValue > k) {
                            break;
                        }
                    }
                }
            }
            return false;
        }
		
		
				

    }
	   
}


