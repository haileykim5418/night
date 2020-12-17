package loopTest1216;

import java.util.Scanner;

public class Test1 {
//for
	public static void main(String[] args) {
		System.out.println("------------------------");
		System.out.println("짝수, 홀수 구분 프로그램 v1.0");
		System.out.println("------------------------");
		Scanner s = new Scanner(System.in); // 스캐너 클래스 객체 생성하겠다 or s라는 변수 생성하겠다 한번만 하면됨
		for (int i = 0; i < 5; i++) {
			System.out.print((i + 1) + ".Num" + (i + 1) + ":");
			int num = s.nextInt();
			if (num % 2 == 0) {
				System.out.println("짝수입니다.");
			}
			else {
				System.out.println("홀수입니다.");
			}

		}
	}
}