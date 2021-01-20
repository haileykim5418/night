package method1230;

import java.util.Scanner;

public class Exam04 {

	public static void score(int a, int b, int c) {
		System.out.println("총점: " + (a + b + c));
		System.out.println("평균: " + (a + b + c)/3);
		}
	
	
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("국어점수: ");
		int kor = s.nextInt();
		System.out.print("영어점수: ");
		int eng = s.nextInt();
		System.out.print("수학점수: ");
		int math = s.nextInt();
		
		score(kor,eng,math);
	}

}
