package test1222;

import java.util.Scanner;

public class Exam3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("---------------------------");
		System.out.println("입력받는 수의 합을 구하는 프로그램");
		System.out.println("---------------------------");
		Scanner s = new Scanner(System.in);
		System.out.print("1.num1입력 :");
		int num1 = s.nextInt();
		System.out.print("1.num1입력 :");
		int num2 = s.nextInt();
		int hap = 0;
		
		if (num2 >num1) {
			System.out.println("num2의 값이 큽니다.");
			System.exit(0);
			//프로그램 강제 종료
		}
		
		for (int i = num1; i<=num2; i++) {
			hap += i;
		}
		
		System.out.printf("%d ~ %d까지의 합 : %d\n",
		num1, num2, hap);
		s.close();
		
	}

}
