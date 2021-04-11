package test;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("숫자입력: ");
		int num = s.nextInt();

		int arr[] = new int[num];

		for (int i = 0; i < arr.length; i++) {
			arr[i] = i;
			arr[i] = s.nextInt();
			Arrays.sort(arr);
			System.out.println(arr[0]+","+arr[i-1]);
		}	
			

		
	}

}
