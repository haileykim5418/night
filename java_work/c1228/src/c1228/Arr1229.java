package c1228;

import java.util.Arrays;
import java.util.Scanner;

public class Arr1229 {

	public static void main(String[] args) {
		
		//숫자 n개를 입력받아 가장 큰 수랑 작은 수 출력
		
		System.out.println("1번 문제");
		
		Scanner s = new Scanner(System.in);
		System.out.println("몇개 입력");
		int n = s.nextInt();
		System.out.println("숫자 입력");
		
		int[] numberList = new int[n];
		for(int i = 0; i<n; i++) {
			numberList[i] = s.nextInt();
		}
		
		//최대 최소 비교
		int max = numberList[0];
		int min = numberList[0];
		
		
		for(int i = 0; i< numberList.length; i++) {
				if(numberList[i] > max)
					max = numberList[i];
				if(numberList[i]<min)
					min = numberList[i];
		
		}
		System.out.println("최솟값 : " + min);
		System.out.println("최댓값 : " + max);
		
		//두번째
		Arrays.sort(numberList);
		System.out.println("최솟값 : " + numberList[0]);
		System.out.println("최댓값 : "+ numberList[numberList.length-1]);


	}
}


