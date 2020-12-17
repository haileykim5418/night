package loopTest1216;

import java.util.Scanner;

public class Test1_1 {
//while
	public static void main(String[] args) {
		System.out.println("------------------------");
		System.out.println("짝수, 홀수 구분 프로그램 v1.0");
		System.out.println("------------------------");
		Scanner s =new Scanner(System.in);
		int i = 0;
		while (i<5) { 
			System.out.print((i+1) + ".num" + (i+1) + ":");
			int num = s.nextInt();
		if (num%2 == 0) { 
			System.out.println("짝수입니다.");
		}
		else {
			System.out.println("홀수입니다.");
		}
		i++;
		}
	}

}
