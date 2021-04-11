package arr1223;

import java.util.Scanner;

public class Test2 {

	public static void main(String[] args) {

		int arr[] = new int[101];
		for (int i = 1; i < arr.length; i++) {
			arr[i] = i;
			if (i % 5 == 0) {
				System.out.println(arr[i]);
			}
		}
		System.out.println("-------------------------");
		for (int i = 1; i < arr.length; i++) {
			arr[i] = i;

			System.out.println(arr[i]);
			if (arr[i] == 90) {
				System.exit(0);
			}
		}

	}

}
