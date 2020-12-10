package inputTest;

import java.util.Scanner;

public class Input4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		float PI = 3.14f;
		float half = 3f;
		
		System.out.println("원의 면적 : " + (half * half * PI));
		
		
	
		Scanner s = new Scanner(System.in);
		System.out.print("반지름 : ");
		float h = s.nextFloat();
		
		float PI = 3.14f;
		
		System.out.println("면적 : " + (PI * s * s));
		
		
			
	}

}
