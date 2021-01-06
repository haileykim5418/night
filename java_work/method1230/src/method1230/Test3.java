package method1230;

import java.util.Random;

public class Test3 {

	public static void main(String[] args) {
//	int arr [] = new int [10];
//	for (int i = 0; i < arr.length; i++) {
//		arr[i] = (int) (Math.random() * 100 + 1);
//	}
//	func(arr);
//	}
//
//	public static void func(int arr[]) {
//		for (int i = 0; i < arr.length; i++) {
//			if(arr[i]%2==0) {
//				System.out.println(arr[i] + " : 짝수");
//			}else {
//				System.out.println(arr[i] + " : 홀수");
//			}
//		}

//		int a = 10;
//		int arr[] = new int [a]; .아래와 같은 의미
		
		int arr[] = new int[10];   //비어있는 배열10
		Random rand = new Random();
		for (int i=0; i<arr.length; i++) {
			arr[i]= rand.nextInt(100);
//			System.out.println(arr[i]);
		}
		evenOdd(arr);
		}
	public static void evenOdd(int arr[]) {
		for (int i : arr) {
			if (i%2!=0) {
				System.out.println(i+"=홀수");
			}
			else {
				System.out.println(i+"=짝수");
			}
		}
	}
}


