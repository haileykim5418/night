package test2;

public class Test4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		byte b = 127;
		int i = 100;
		//b가 자동으로 int타입으로 변환 =>타입 변환, 타입 캐스팅
		System.out.println(b + i);
		System.out.println(10 / 4);
		System.out.println(10.0 / 4);
		//4가 자동으로 4.0으로 변환
		
		int num = 10;
		int num2 = 4;
		System.out.println(num / num2);
		//4가 자동으로 4.0으로 변환
		
		//65라는 숫자를 아스키코드로 바꿔라
		System.out.println((char)65);
		
		System.out.println((int)2.9 + 1.8);
		System.out.println((int)(2.9 + 1.8));
		System.out.println((int)2.9 + (int)1.8);
		
	}

}
