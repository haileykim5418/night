package com.jb.addrApp.util;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;
import com.jb.addrApp.model.AddrBook;

public class Menu {
	// static이 붙은 상수변수는 객체를 생성하지 않고 접근할 수 있다.
	// 한번 만들어두고 공통으로 계속 사용하고 관리하기 위함
	// 내부에서만 쓰던것을 외부에서도 쓰기 위해 public 붙임
	public static final int CREATE_TABLE = 1;
	public static final int DEL_TABLE = 2;
	public static final int INSERT_DATA = 3;
	public static final int RANDOM_DATA = 4;
	public static final int VIEW_DATA = 5;
	public static final int UPDATE_DATA = 6;
	public static final int DEL_DATA = 7;
	public static final int MAIN_EXIT = 8;
	
	public static final int UP_NAME =1;
	public static final int UP_AGE =2;
	public static final int UP_TEL =3;
	public static final int UP_ADDR =4;
	public static final int UP_EMAIL =5;
		
	public int mainMenu(Scanner s) {
		System.out.println("----------------------");
		System.out.println("MySQL DB 관리 v1.0");
		System.out.println("----------------------");
		System.out.println("1. 테이블 생성");
		System.out.println("2. 테이블 삭제");
		System.out.println("3. 데이터 추가");
		System.out.println("4. 랜덤 데이터");
		System.out.println("5. 데이터 보기");
		System.out.println("6. 데이터 수정");
		System.out.println("7. 데이터 삭제");
		System.out.println("8. 종료");
		System.out.print("메인 메뉴 선택 : ");
		return s.nextInt();
	}
	

	public AddrBook addMenu(Scanner s) {
		System.out.println("----------------------");
		System.out.println("데이터 추가 메뉴");
		System.out.println("----------------------");
		System.out.print("이름 : ");
		String name = s.next();
		System.out.print("나이 : ");
		int age = s.nextInt();
		System.out.print("전화 : ");
		String tel = s.next();
		
		//주소 띄어쓰기시 오류발생 디버깅
		BufferedReader br = 
				new BufferedReader(new InputStreamReader(System.in));
		System.out.print("주소 : ");
		String addr = null;
		try {
			addr = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		
		System.out.print("메일 : ");
		String email = s.next();
		return new AddrBook(name, age, tel, addr, email);
	}
	
	public int UpdateMenu(Scanner s) {
		System.out.println("----------------------");
		System.out.println("데이터 수정하기");
		System.out.println("----------------------");
		System.out.println("1.이름");
		System.out.println("2.나이");
		System.out.println("3.번호");
		System.out.println("4.주소");
		System.out.println("5.메일");
		System.out.println("----------------------");
		System.out.print("수정할 항목을 선택하세요 : ");
			
		return s.nextInt();
	}
	
	
}
