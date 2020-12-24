package arr1223;

import java.util.Scanner;

public class Test3 {

	public static void main(String[] args) {

		int arr[] = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
		int arr2[] = new int[10];

		for (int j = 0; j < arr.length; j++) {
			arr2[j] = arr[9 - j];
			System.out.print(arr2[j]+"\n");

		}

	}

}
