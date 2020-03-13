public class Solution {
//can be  faster
    public int MajorityElement(int[] nums) {
   	Array.Sort(nums);
			var len=nums.Length;		 
			int midlen=len/2;			 		
			return 	 nums[midlen];
    }
}