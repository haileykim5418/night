package switch1215;

import java.util.Scanner;

public class Test2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("------------------------");
		System.out.println("간단한 계산기 프로그램 v1.0");
		System.out.println("------------------------");
		System.out.print("num1입력 : ");
		int num1 = s. nextInt();
		System.out.print("num2입력 : ");
		int num2 = s. nextInt();
		System.out.print("연산자 입력 : ");
		String a = s. next();
		int result = 0;
		
		switch (a) {
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
			result = num1 - num2;
		break;
	
		}
		
		s.close();
		System.out.println(num1 + a + num2 + "=" + result);
	}

}
