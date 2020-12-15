package if1209;

import java.util.Scanner;

public class IF6 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("num1 입력: ");
		int op1 = s.nextInt();
		System.out.print("num2 입력: ");
		int op2 = s.nextInt();
		System.out.print("연산자 입력: ");
		String oper = s.next();
		int result = 0;
		
		if (oper.equals("+")) {
			result = op1 + op2;
		}
		else if (oper.equals("-")) {
			result = op1 - op2;
		}
		else if ( oper.equals("*")) {
			result = op1 * op2;
		}
		else if (oper.equals("/")) {
			result = op1 / op2;
		}
		System.out.println((int) op1 + oper + op2 + "=" + result);
		
		//%d :정수 - op1에 치환 %s : 문자열 - oper에 치환 \n은 뉴라인, t는 탭
		System.out.printf("%d %s %d = %d\n", (int)op1, oper, (int)op2, (int)result);
		s.close();
	}

}
