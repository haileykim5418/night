package switch1215;

import java.util.Scanner;

public class Test3 {

	public static void main(String[] args) {
		System.out.println("----------------------------");
		System.out.println("담배 자판기 프로그램 v1.0");
		System.out.println("----------------------------");
		System.out.println("원하는 음료수를 메뉴에서 선택하세요.");
		System.out.println("1. 에쎄 골든 리프    6,000원");
		System.out.println("2. 에쎄 스페셜 골드   5,000원");
		System.out.println("3. 더원 블루        4,500원");
		System.out.println("4. 더원 오렌지       4,500원");
		System.out.println("5. 더원 화이트       4,500원");
		System.out.println("----------------------------");
		Scanner s = new Scanner(System.in);
		
		System.out.print("담배를 선택하세요 : ");
		int cig = s. nextInt();
		int coin = 0;
		int result = 0;
		
		switch(cig) {
		case 1 :
			System.out.println("에쎄 골든 리프를 선택하셨습니다.");
			System.out.print("담배금액을 입력하세요 : ");
			coin = s.nextInt();
			System.out.println("에쎄 골든리프를 구매했습니다. 거스름돈"  + (coin-6000) + "원을 받으세요");
			break;
		case 2 :
			System.out.println("에쎄 스페셜 골드를 선택하셨습니다.");
			System.out.print("담배금액을 입력하세요 : ");
			coin = s.nextInt();
			System.out.println("에쎄 스페셜 골드를 구매했습니다. 거스름돈"  + (coin-5000) + "원을 받으세요");
			
			break;
		case 3 :
			System.out.println("더원 블루를 선택하셨습니다.");
			System.out.print("담배금액을 입력하세요 : ");
			coin = s.nextInt();
			System.out.println("더원 블루를 구매했습니다. 거스름돈"  + (coin-4500) + "원을 받으세요");
			break;
		case 4 :
			System.out.println("더원 오렌지를 선택하셨습니다.");
			System.out.print("담배금액을 입력하세요 : ");
			coin = s.nextInt();
			System.out.println("더원 오렌지를 구매했습니다. 거스름돈"  + (coin-4500) + "원을 받으세요");
			break;
		case 5 :
			System.out.println("더원 화이트를 선택하셨습니다.");
			System.out.print("담배금액을 입력하세요 : ");
			coin = s.nextInt();
			System.out.println("더원 화이트를 구매했습니다. 거스름돈"  + (coin-4500) + "원을 받으세요");
			break;
			
		}
		
		System.out.println("----------------------------");
	
		
		
		s.close();
		
}}
