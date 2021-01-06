package method1230;

import java.util.Scanner;

public class Test2 {
	public static int func(int num1, String a, int num2) {
		int result = 0;
		switch (a){
		case "+" :
			result = num1 + num2;
			break;
		case "-" :
			result = num1 - num2;
			break;
		case "*" :
			result = num1 * num2;
			break;
		case "/" :
			result = num1 / num2;
			break;
		}
		return result;
	}
	public static void main(String[] args) {
		int result;
		Scanner s = new Scanner(System.in);
		System.out.print("num1값 입력 : ");
		int num1 = s.nextInt();
		System.out.print("연산자 입력 :");
		String a = s.next();
		System.out.print("num2값 입력 :");
		int num2 = s.nextInt();
		int aa = func(num1,a,num2);
		System.out.printf("%d %s %d = %d", num1, a, num2, func(num1,a,num2));
		
		
		
	}

}
