package method1230;

import java.util.Scanner;

public class Test4 {

	public static void main(String[] args) {
	Scanner s = new Scanner(System.in);
	System.out.print("국어점수 입력:");
	int kor = s.nextInt();
	while(true) {
		if(kor>100) {
			System.out.println("다시입력해주세요");
			System.out.print("국어점수 입력:");
			kor = s.nextInt();
		}else {
			break;
		}
	}
	if(kor>100) {
		System.out.println("다시입력해주세요");
		return;
	}
	System.out.print("수학점수 입력:");
	int math = s.nextInt();
	System.out.print("영어점수 입력:");
	int eng = s.nextInt();
	
	score(kor,math,eng);
	}
	public static void score(int a, int b, int c) {
		int result1 = (a+b+c);
		int result2 = (a+b+c)/3;
		System.out.println("총점 : "+result1);
		System.out.println("평균 : "+ result2);
	}

}
