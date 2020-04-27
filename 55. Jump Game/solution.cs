public static bool CanJump(int[] nums)
		{
			int n = nums.Length;
			int rightMost = 0;
			for (int i = 0; i < n; i++) {
				if (i < rightMost) {
					rightMost = Math.Max(rightMost, i + nums[i]);
				}
				if (rightMost > n - 1) {
					return true;
				}
			}
			return false;
		}