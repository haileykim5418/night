package inputTest;

import java.util.Scanner;

public class Input1 {

	public static void main(String[] args) {
		//scanner 객체(=s)생성 객체
		Scanner s = new Scanner(System.in);
		System.out.print("이름을 입력 : ");
		//키보드 문자열 입력
		String name = s.nextLine();
		//정수 입력
		System.out.print("나이 입력 : ");
		int age = s.nextInt();
		
		System.out.print("이름 정보 : " + name);
		System.out.print("나이 정보 : " + age);
		s.close();
		
	}

}
