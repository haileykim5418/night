package if1209;

import java.util.Scanner;


public class IF5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.println("-------------------");
		System.out.println("가위 바위 보 게임 1.0  ");
		System.out.println("-------------------");
		System.out.print("홍길동 입력: ");
		String hong = s.next();
		System.out.println("김길동 입력: ");
		String kim = s.next();
		
		//String 문자열 비교
		if (hong.equals("가위")) {
			if (kim. equals ("가위")) {
				System.out.println("비겼습니다.");
			}
			else if (kim.equals("바위")) {
				System.out.println("김길동이 이겼습니다.");
			}}
			else if (kim.equals("보")) {
				System.out.println("홍길동이 이겼습니다.");
			}


			if (hong.equals("바위")) {
			if (kim. equals ("가위")) {
				System.out.println("홍길돟이 이겼습니다.");
			}
			else if (kim.equals("바위")) {
				System.out.println("비겼습니다.");
			}}
			else if (kim.equals("보")) {
				System.out.println("김길동이 이겼습니다.");
			}
			else {
		         if (kim.equals("가위")) {
		            System.out.println("김길동이 이겼습니다.");
		         }
		         else if (kim.equals("바위")) {
		            System.out.println("홍길동이 이겼습니다.");
		         }
		         else if (kim.equals("보")){   // else if를 써도 됨
		            System.out.println("비겼습니다.");
		         }}}}
		         
		      
		  


			
	
	
