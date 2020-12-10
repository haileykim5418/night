package inputTest;

import java.util.Scanner;

public class Input3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner s = new Scanner(System.in);
		System.out.print("주행거리 입력: ");
		double juhang = s.nextDouble();
		System.out.print("사용한 휘발유 양 입력:");
		double fuels = s.nextDouble();
		//연비 구함
		double yeonbi = juhang / fuels;
		System.out.println("차량연비: " + yeonbi);
		s.close();
		
	}

}
