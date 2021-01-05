package method1230;

import java.util.Scanner;

public class Test5 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("숫자입력:");
		int num = s.nextInt();

		gugu(num);
	}

	public static void gugu(int a) {
		for (int i = 1; i <= 9; i++) {
			System.out.println(a + "X" + i + "=" + (a * i));
		}

	}
}
