package switch1215;

import java.io.IOException;
import java.util.Scanner;

public class Test1 {

	public static void main(String[] args) throws IOException {
		
		
		System.out.println("-----------------------------");
		System.out.println(" 식당 메뉴 자동 주문 프로그램 v1.0 ");
		System.out.println("-----------------------------");
		System.out.println("원하는 식사를 선택하세요.");
		System.out.println("a. 김치찌개 : 5,000원");
		System.out.println("b. 된장찌개 : 5,000원");
		System.out.println("c. 칼국수 : 4,500원");
		System.out.println("d. 잔치국수 : 4,000원");
		System.out.println("e. 비빔밥 : 5,000원");
		System.out.print("메뉴를 선택해주세요 : ");
		int coin = 0;
		
		char str = (char)System.in.read();
		Scanner s = new Scanner(System.in);
		
		switch(str) {
		case 'a' :
			System.out.println("김치찌개를 주문했습니다.");
			int a1 = 5000;
			
		break;
		
	
		case 'b' :
			System.out.println("된장찌개를 주문했습니다.");
			int a2 = 5000;
		break;
		
		case 'c' :
			System.out.println("칼국수를 주문했습니다.");
			int a3 = 4500;
		break;
		
		
		case 'd' :
			System.out.println("잔치국수를 주문했습니다.");
			int a4 = 4000;
		break;
		
		
		case 'e' :
			System.out.println("비빔밥을 주문했습니다.");
			int a5 = 5000;
		break;
		}
		System.out.print("금액을 입금하세요 : ");
		coin = s.nextInt();
		System.out.println("거스름돈" + coin + "을 받으세요");
		}
		}


