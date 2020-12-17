package loopTest1216;

import java.util.Scanner;

public class Test1_2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int i=0;
		System.out.print(i+1 + ". num" + i+1 + ":");
		int num = s.nextInt();
		do {
			if(num%2 == 0) {
				System.out.println("짝수입니다.");}
				else {
					System.out.println("홀수입니다.");
				}
				i++;
		}
		while(i<5);
			}
		}



