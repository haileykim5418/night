package method1230;

import java.util.Scanner;

public class Test10 {
//재귀
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("팩토리얼 수 입력: ");
		int n = s.nextInt();

		int result = factorial(n);
		System.out.println(n + "!=" + result);
	}

	public static int factorial(int n) {
		if (n == 1) {
			return 1;
		} else {
			return n * factorial(n - 1);
		}
	}
}
