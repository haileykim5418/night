package arr1223;

import java.util.Scanner;

public class Test1 {

	public static void main(String[] args) {
		
		int arr[] = { 20, 34, 22, 14, 36, 23, 67, 25, 99, 88 };
		int sum=0;
		for(int i = 0; i<arr.length; i++) {
			sum+=arr[i];
		}
		System.out.println("배열의 합: " + sum);
		System.out.println("배열의 평균: "+ sum/arr.length);
		
	}

}
