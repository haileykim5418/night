package if1209;

import java.util.Scanner;


public class Test5 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("-----------------------------");
		System.out.println("     학점 관리 프로그램 v1.0     ");
		System.out.println("-----------------------------");
		System.out.println("   100 ~ 90   : A학점         ");
		System.out.println("   89 ~ 80    : B학점         ");
		System.out.println("   79 ~ 70    : C학점         ");
		System.out.println("   69 ~ 60    : D학점         ");
		System.out.println("   59 ~ 50    : E학점         ");
		System.out.println("   49 ~ 0     : F학점         ");
		System.out.println("-----------------------------");
		
		int kor = 0;
		int eng = 0;
		int math = 0;
		
		Scanner s = new Scanner(System.in);
		System.out.print("국어 점수 입력 : ");
		kor = s.nextInt();
		System.out.print("영어 점수 입력 : ");
		eng = s.nextInt();
		System.out.print("수학 점수 입력 : ");
		math = s.nextInt();
		
		int sum = kor + eng + math;
		int eve = (kor + eng + math)/3;
		
		System.out.println("총점 : " + sum);
		System.out.println("평균 : " + eve);
		
		if(eve >= 90 && eve <= 100) {
			System.out.println("학점은 A입니다.");
			}
		else if (eve >= 80 && eve <= 89) {
			System.out.println("학점은 B입니다.");
		}
		else if (eve >= 70 && eve <= 79) {
			System.out.println("학점은 C입니다.");
		}
		else if (eve >= 70 && eve <= 69) {
			System.out.println("학점은 D입니다.");
		}
		else if (eve >= 60 && eve <= 59) {
			System.out.println("학점은 E입니다.");
		}
		else if (eve >= 0 && eve <= 49) {
			System.out.println("학점은 F입니다.");
		}
		
	
	}

}