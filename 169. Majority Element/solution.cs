public class Solution {
//can be  faster
    public int MajorityElement(int[] nums) {
   	Array.Sort(nums);
			var len=nums.Length;		 
			int midlen=len/2;			 		
			return 	 nums[midlen];
    }
	//2020-06-12 15:51:33
	public  int MajorityElement(int[] nums)
		{
			int n = nums.Length;
			if (n == 1) {
				return nums[0];
			}
			var map = new Dictionary<int,int>();
			for (int i = 0; i < n; i++) {
				if (map.ContainsKey(nums[i])) {
					map[nums[i]]++;
					var value = map[nums[i]];
					if (value > n / 2) {
						return nums[i];
					}
				} else {
					map.Add(nums[i], 1);
				}
			}
			return 0;
		}
}