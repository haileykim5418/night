package test1222;

import java.io.BufferedOutputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Scanner;

public class Loop4 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		while(true)
		{
		System.out.println("-----------------------");
		System.out.println("간단한 파일 관리 프로그램");
		System.out.println("-----------------------");
		System.out.println("1. 파일 생성 및 쓰기");
		System.out.println("2. 파일 읽기");
		System.out.println("3. 종료");
		System.out.println("-----------------------");
		System.out.print("메뉴를 선택하세요:");
		int menu = s.nextInt();
		String str = null;
		String fileName = "D:/test1.txt";
		switch (menu) {
		case 1:
			System.out.println("1. 파일 생성 및 쓰기");
			BufferedOutputStream bs;
			
			try {
			bs = new BufferedOutputStream(new FileOutputStream(fileName));
			str = "파일 생성 및 쓰기 예제입니다.";
			bs.write(str.getBytes());
			bs.close();
			} catch(FileNotFoundException e) {
				e.printStackTrace();
			} catch (IOException e) {
				e.printStackTrace();
			}
			System.out.println("파일명:"+fileName);
			System.out.println("파일내용: "+str);
			System.out.println("파일 생성이 성공하였습니다.");
			break;
			
		case 2:
			System.out.println("2. 파일 읽기");
			break;
		case 3:
			System.out.println("프로그램 종료");
			s.close();
			System.exit(0);
			break;
		default:
			System.out.println("잘못된 입력입니다.");
			break;

		}
		
		}
	}
}


