package method1230;

import java.util.Random;
import java.util.Scanner;

public class Exam03 {

	public static void number(int array[]) {
		for (int i = 0; i < array.length; i++) {
			if (array[i] % 2 == 0) {
				System.out.println(array[i] + "짝수입니다");
			} else {
				System.out.println(array[i] + "홀수입니다");
			}

		}
	}

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int array[] = new int[10];
		Random r = new Random();
		for (int i = 0; i < array.length; i++) {
			array[i] = r.nextInt(100);
		}
		number(array);
	}
}
