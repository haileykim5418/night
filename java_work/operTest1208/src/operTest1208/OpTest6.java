package operTest1208;

import java.util.Scanner;

public class OpTest6 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int coin500 = 0, coin100 = 0, coin50 = 0, coin10 = 0;
		
		Scanner s = new Scanner(System.in);
		System.out.print("금액을 입력하세요 : ");
		int input = s.nextInt();
		
		coin500 = input / 500;
		int na = input % 500;  //na=나머지
		//System.out.println("500원 나머지 : " + na);
		
		coin100 = na / 100;
		na = na % 100; // na %= 100;
		//System.out.println("100원에 대한 나머지 " + na);
		
		coin50 = na / 50;
		
		
		
		System.out.println("-------------------------");
		System.out.println("   동전 교환기 프로그램 1.0   ");
		System.out.println("-------------------------");
		System.out.println("오백원 갯수:" + coin500 + "개");
		System.out.println("백원 갯수:" + coin100 + "개");
		System.out.println("오십원 갯수:" + coin50 + "개");
		System.out.println("십원 갯수              : ?개");
		System.out.println("나머지 잔돈             : ?개");
		s.close();
		


	}

}
