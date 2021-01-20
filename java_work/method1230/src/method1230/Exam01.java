package method1230;

import java.util.Scanner;

public class Exam01 {

	public static void main(String[] args) {
		Scanner a = new Scanner(System.in);
		System.out.print("숫자입력1: ");
		int a1 = a.nextInt();
		System.out.print("숫자입력2: ");
		int a2 = a.nextInt();
		System.out.print("숫자입력3: ");
		int a3 = a.nextInt();
		
		number(a1, a2, a3);

	}

	public static void number(int a1, int a2, int a3) {
		if (a1 > a2 && a1 > a3 && a2 > a3) {// a1-a2-a3
			System.out.println(a1 +"-"+ a2 +"-"+ a3);
		} else if (a1 > a2 && a1 > a3 && a3 > a2) {// a1-a3-a2
			System.out.println(a1 +"-"+ a3 +"-"+ a2);
		} else if (a2 > a1 && a1 > a3 && a2 > a3) {// a2-a1-a3
			System.out.println(a2 +"-"+ a1 +"-"+ a3);
		} else if (a2 > a3 && a2 > a1 && a3 > a1) {// a2-a3-a1
			System.out.println(a2 + "-" +a3 +"-"+ a1);
		} else if (a3 > a1 && a3 > a2 && a1 > a2) {// a3-a1-a2
			System.out.println(a3 + "-" + a1 +"-"+ a2);
		} else if (a3 > a2 && a3 > a1 && a2 > a1) {// a3-a2-a1
			System.out.println(a3 +"-"+ a2 +"-" +a1);
		}

	}
}
