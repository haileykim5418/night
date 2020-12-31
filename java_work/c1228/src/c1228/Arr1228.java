package c1228;

import java.util.Scanner;

public class Arr1228 {

	public static void main(String[] args) {
		
		//숫자 n개를 입력받아 가장 큰 수랑 작은 수 출력
		
		Scanner s = new Scanner(System.in);
		System.out.print("입력받을 갯수: ");
		int n = s.nextInt();
		System.out.print("숫자입력");
		
		int[]number = new int[n];
		for(int i=0;i<n;i++) {
			number[i]=s.nextInt();
		}
		int max = number[0];
		int min = number[0];
		
		for(int i =0; i<number.length;i++) {
			if(number[i]>max)
				max = number[i];
			if(number[i]<min)
				min = number[i];
		}
		System.out.println("최솟값 : " + min);
		System.out.println("최댓값 : " + max);
		}
		

	}



