package if1209;

import java.util.Scanner;

public class Test3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("---------------------");
		System.out.println("간단한 계산기 프로그램v1.0");
		System.out.println("---------------------");
		
		Scanner s = new Scanner(System.in);
		int num = 0;
		int num1 = 0;
		String st = "a";
		
		
		System.out.print("첫번째 숫자 입력 : ");
		num = s.nextInt();
		System.out.print("두번째 숫자 입력 : ");
		num1 = s.nextInt();
		System.out.print("연산자 입력 : ");
		st = s.next();
		
		if (st.equals("+")) {System.out.println(num + "+" + num1 + "=" + (num + num1));}
		else if (st.equals("-")) {System.out.println(num + "-" + num1 + "-" + (num + num1));}
		else if (st.equals("*")) {System.out.println(num + "*" + num1 + "=" + (num * num1));}
		else {System.out.println(num + "/" + num1 + "=" + (num / num1));}
		
		
		
	}

}
