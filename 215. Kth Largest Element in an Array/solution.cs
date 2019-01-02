public class Solution {
    public int FindKthLargest(int[] nums, int k) {
          Comparison<int> p = (int a, int b) =>
               {
                   if (a < b) return 1;
                   else if (a == b) return 0;
                   else if (a > b) return -1;
                   return 0;
               };
            Comparison<int> comparison = new Comparison<int>(p);
            List<int> list = nums.ToList();   
            list.Sort(comparison);
        return list[k - 1];
    }
}