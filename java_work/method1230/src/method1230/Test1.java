package method1230;

import java.util.Scanner;

public class Test1 {
	public static void func(int arr) {
		System.out.println(arr);
	}

	
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("숫자1:");
		int a = s.nextInt();
		System.out.print("숫자2:");
		int b = s.nextInt();
		System.out.print("숫자3:");
		int c = s.nextInt();

		int arr[] = { a, b, c };

			if (a > b && a > c && b > c) {// abc
				System.out.println(a + "-" + b + "-" + c);
			} else if (b > a && b > c && a > c) {// bac
				System.out.println(b + "-" + a + "-" + c);
			} else if (a > b && a > c && c > b) {// acb
				System.out.println(a + "-" + c + "-" + b);
			} else if (b > a && b > c && c > a) {// bca
				System.out.println(b + "-" + c + "-" + c);
			}else if (c > a &&  c > b && a > b) {// cab
				System.out.println(c + "-" + a + "-" + b);
			}else if (c > a &&  c > b && b > a) {// cba
				System.out.println(c + "-" + b + "-" + a);
			}
		}




}
