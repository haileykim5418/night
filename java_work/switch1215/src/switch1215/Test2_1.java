package switch1215;

import java.util.Scanner;

public class Test2_1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("----------------------------");
		System.out.println("담배 자판기 프로그램 v1.0");
		System.out.println("----------------------------");
		System.out.println("원하는 음료수를 메뉴에서 선택하세요.");
		System.out.println("1. 에쎄 골든 리프   : 6,000원");
		System.out.println("2. 에쎄 스페셜 골드  : 5,000원");
		System.out.println("3. 더원 블루       : 4,500원");
		System.out.println("4. 더원 오렌지      : 4,500원");
		System.out.println("5. 더원 화이트      : 4,500원");
		System.out.println("----------------------------");
	
		System.out.print("담배를 선택하세요 : ");
		
		Scanner s = new Scanner(System.in);
		int menu = s.nextInt();
		
		switch (menu) {
		case 1 : 
			System.out.println("에쎄 골드 리프를 선택하셨습니다.");
			break;
		case 2 : 
			System.out.println("에쎄 스페셜 골드를 선택하셨습니다.");
			break;
		case 3 : 
			System.out.println("더원 블루를 선택하셨습니다.");
			break;
		case 4 : 
			System.out.println("더원 오렌지를 선택하셨습니다.");
			break;
		case 5 : 
			System.out.println("더원 화이트를 선택하셨습니다.");
			break;
			
		}
		System.out.println("----------------------------");
		System.out.print("담배 금액을 투입하세요 : ");
		
		int input = s.nextInt();
		int na = 0;
		
		switch (menu) {
		case 1: //6000
			na = input - 6000;
			if (na > 0) {
			System.out.println("에쎄 골든 리프를 구매했습니다. 거스름돈" + na + "을 받으세요");
			}
			else if (na == 0) {
				System.out.println("에쎄 골든 리프를 구매했습니다.");
			}
			else {
				System.out.println("추가금액" + Math.abs(na) + "을 투입하세요"); // math.abs말고도 (na * (-1))으로도 가능
			}
			break;
		case 2:
			break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			break;
		}
	}
	
}
