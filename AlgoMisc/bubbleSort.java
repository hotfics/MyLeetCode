public class T {

	public static void main(String[] args) {
		int[] tarr = { 7, 5, 8, 6, 2, 10, 3, 1, 11, 3, 4 };
		bubbleSort(tarr);
		for (int i = 0; i < tarr.length; i++) {
			System.out.println(tarr[i]);
		}

	}

	public static void bubbleSort(int[] arr) {
		int temp;
		for (int i = 0; i < arr.length - 1; i++) {
			for (int j = 0; j < arr.length - 1 - i; j++)
				if (arr[j] > arr[j + 1]) {
					temp = arr[j + 1];
					arr[j + 1] = arr[j];
					arr[j] = temp;
				}
		}
	}
}
