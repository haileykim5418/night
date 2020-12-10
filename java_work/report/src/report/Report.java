package report;

import java.util.Scanner;

public class Report {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		
		System.out.print("국어 점수 :");
		int num1 = s.nextInt();
		System.out.print("영어 점수 :");
		int num2 = s.nextInt();
		System.out.print("수학 점수 :");
		int num3 = s.nextInt();
		System.out.print("과학 점수 :");
		int num4 = s.nextInt();
		
		
		
		
		int eve = (num1 + num2 + num3 + num4)/4;
		int hap = num1 + num2 + num3 + num4;
		
		System.out.println("평균점수:" + eve);
		System.out.println("합계:" + hap);
		
		s.close();
		
				

	}

}
