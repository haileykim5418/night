package if1209;

import java.util.Scanner;

public class Test2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("-------------------");
		System.out.println("대소 비교 프로그램 v1.0");
		System.out.println("-------------------");
		
		Scanner s = new Scanner(System.in);
		int num1 = 0;
		int num2 = 0;
		System.out.print("첫번째 숫자 입력 : ");
		num1 = s.nextInt();
		
		System.out.print("두번째 숫자 입력 : ");
		num2 = s.nextInt();
		s.close();
		
		
		if (num1 < num2) {
			System.out.println("첫번째 숫자가 두번째 숫자보다 크다.");}
			else if (num2 > num1) {
			System.out.println("두번째 숫자가가 첫번째 숫자보다 크다.");
		}
			else {System.out.println("첫번째 숫자와 두번째 숫자는 같다.");}
			
		}
		
}
