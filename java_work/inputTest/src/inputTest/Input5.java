package inputTest;

import java.util.Scanner;

public class Input5 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("반지름 : ");
		float h = s.nextFloat();
		
		float PI = 3.14f;
		
		System.out.println("면적 : " + (PI * h * h));
		
		s.close();
	}

}
