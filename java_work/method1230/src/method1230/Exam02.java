package method1230;

import java.util.Scanner;

public class Exam02 {
	public static int number(int num1, String a, int num2) {
		int result = 0;
		switch(a) {
		case "+" :
			System.out.println(num1 + num2);
		break;
		case "-" :
			System.out.println(num1 - num2);
		break;
		case "*" :
			System.out.println(num1 * num2);
		break;
		case "/" :
			System.out.println(num1 / num2);
		break;
		
		}
		
		return result;
	}
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("숫자1: ");
		int num1 = s.nextInt();
		System.out.print("숫자2: ");
		int num2 = s.nextInt();
		System.out.print("연산자: ");
		String a = s.next();
		
		number(num1,a,num2);
	}

}
