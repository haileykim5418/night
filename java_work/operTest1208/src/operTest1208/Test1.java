package operTest1208;

import java.util.Scanner;

public class Test1 {

	public static void main(String[] args) {
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		
		num = 500;
		num2 = 100;
		num3 = 50;
		num4 = 10;
		
		Scanner s = new Scanner (System.in);
		System.out.print("지폐 : " );
		int put = s.nextInt();
		
		System.out.println("------------------------");
		System.out.println("  동전 교환기 프로그램 1.0   ");
		System.out.println("------------------------");
		System.out.println("500원의 갯수 : " + put/num);
		System.out.println("100원 갯수 : " + (put%num)/num2);
		System.out.println("50원 갯수 : " +  ((put%num)%num2)/num3);
		System.out.println("10원 갯수 : " + ((put%num)%num2)%num3/num4);
		System.out.println("바꾸지 못한 잔돈 : " + ((put%num)%num2)%num3%num4/1);
		System.out.println("------------------------");
			
		s.close();
		

	}

}
