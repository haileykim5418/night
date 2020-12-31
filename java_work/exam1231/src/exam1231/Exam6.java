package exam1231;

import java.util.Scanner;

public class Exam6 {

	public static void main(String[] args) {
		Scanner s= new Scanner(System.in);
		
		System.out.print("n입력: ");
		int n = s.nextInt();
		System.out.print("m입력: ");
		int m = s.nextInt();
		
		int sum=0;
		for(int i=0; i<=n; i++) {
			if(n%2==0 && i%m!=0) {
				sum+=i;
				
			}
		}
		System.out.println("m의 배수를 제외한 합: "+(sum));
		
	}
}

