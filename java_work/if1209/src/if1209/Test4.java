package if1209;

import java.util.Scanner;

public class Test4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("--------------------------");
		System.out.println(" 년도별 윤년 구분 프로그램v1.0  ");
		System.out.println("--------------------------");
		
		Scanner s = new Scanner(System.in);
		int year = 0;
		System.out.print("년도 입력 : ");
		year = s.nextInt();
		
		if ((year%4 == 0 && year%100 != 0) || (year % 400 == 0))
		
		 {System.out.println( year +"년은 윤년입니다.");
		 
		 }
		else { System.out.println( year +"년은 윤년이 아닙니다.");
		}}}
		
	
	


