package test1222;

import java.util.Scanner;

public class Test6 {

	public static void main(String[] args) {
		
		Scanner s = new Scanner(System.in);
		System.out.println("-----------------------");
		System.out.println("간단한 파일 관리 프로그램");
		System.out.println("-----------------------");
		System.out.println("1. 파일 생성 및 쓰기");
		System.out.println("2. 파일 읽기");
		System.out.println("3. 종료");
		System.out.println("-----------------------");
		System.out.print("메뉴를 선택하세요:");
		int menu = s.nextInt();
		switch(menu) {
		case 1 :
			System.out.println("1. 파일 생성 및 쓰기");
			System.out.println("파일명 : test1.txt");
			System.out.println("파일내용 : 파일 생성 및쓰기 예제입니다");
			System.out.println("파일 생성이 성공하였습니다");
			break;
		
		case 2 :
			System.out.println("2. 파일 읽기");
			System.out.println("파일명 : test2.txt");
			System.out.println("파일내용 : 파일 생성 테스트입니다");
			System.out.println("파일 읽기가 성공하였습니다");
			break;
		case 3 :
			break;
			
			
		default :
		System.out.println("잘못된 입력입니다");
		
		break;}
	
		}
		
		
		
	}


