using System;
using System.Linq;
namespace a
{
	class solution
	{
		static void Main(string[] args)
		{
			int[] arr = {
				0,
				1,
				1,
				1,
				4,
				5,
				3,
				7,
				7,
				8,
				10,
				2,
				7,
				8,
				0,
				5,
				2,
				16,
				12,
				1,
				19,
				15,
				5,
				18,
				2,
				2,
				22,
				15,
				8,
				22,
				17,
				6,
				22,
				6,
				22,
				26,
				32,
				8,
				10,
				11,
				2,
				26,
				9,
				12,
				9,
				7,
				28,
				33,
				20,
				7,
				2,
				17,
				44,
				3,
				52,
				27,
				2,
				23,
				19,
				56,
				56,
				58,
				36,
				31,
				1,
				19,
				19,
				6,
				65,
				49,
				27,
				63,
				29,
				1,
				69,
				47,
				56,
				61,
				40,
				43,
				10,
				71,
				60,
				66,
				42,
				44,
				10,
				12,
				83,
				69,
				73,
				2,
				65,
				93,
				92,
				47,
				35,
				39,
				13,
				75
			}; 
			int n = arr.Length; 
  
        
  
			Console.WriteLine("Sorted array is"); 
			printArray(GetLeastNumbers(arr, 75)); 
	 	 
			Console.ReadKey();
		}
		public static int[] GetLeastNumbers(int[] arr, int k)
		{
			int size = arr.Length;
			var result = new int[k];
			int[] tmpHeap = new int[k];
			Array.Copy(arr, tmpHeap, k);
			buildHeap(tmpHeap);
			if (arr.Length < 20) {
				Array.Sort(arr);
				Array.Copy(arr, result, k);
			} else {
				for (int i = k; i < arr.Length; i++) {
					if (tmpHeap[0] > arr[i]) {
						tmpHeap[0] = arr[i];
						heapify(tmpHeap, 0);
					}
				}
				Array.Copy(tmpHeap, result, k);
			}
			
			
			return result;
		}
		static void buildHeap(int[] nums)
		{
			var lastNonLeaf = (nums.Length - 1) / 2;
			for (int i = lastNonLeaf; i >= 0; i--) {
				heapify(nums, i);
			}
		}
		static void swap(int[] nums, int x, int y)
		{
			var r = nums[x];
			nums[x] = nums[y];
			nums[y] = r;
		}
		private static void heapify(int[] nums, int i)
		{
			var left = 2 * i + 1;
			var right = 2 * i + 2;
			if (left < nums.Length && nums[left] > nums[i] && (right >= nums.Length || nums[left] >= nums[right])) {
				swap(nums, i, left);
				heapify(nums, left);
			} else if (right < nums.Length && nums[right] > nums[i] && (left >= nums.Length || nums[right] >= nums[left])) {
				swap(nums, i, right);
				heapify(nums, right);
			}
		
		}
		//		public static void sort(int[] arr)
		//		{
		//			int n = arr.Length;
		//
		//			// Build heap (rearrange array)
		//			for (int i = n / 2 - 1; i >= 0; i--)
		//				heapify(arr, n, i);
		//
		//			// One by one extract an element from heap
		//			for (int i = n - 1; i >= 0; i--) {
		//				// Move current root to end
		//				int temp = arr[0];
		//				arr[0] = arr[i];
		//				arr[i] = temp;
		//
		//				// call max heapify on the reduced heap
		//				heapify(arr, i, 0);
		//			}
		//		}
		static void printArray(int[] arr)
		{ 
			int n = arr.Length; 
			for (int i = 0; i < n; ++i)
				Console.Write(arr[i] + " "); 
			Console.Read(); 
		}
			
		
	}
	 
}