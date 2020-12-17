package loopTest1216;

public class Loop8 {

	public static void main(String[] args) {
		int hap = 0;
		for (int i=0; i<10; i++) {
			if ((i+1 % 3) == 0) //3으로 나눈 나머지가 0=>3의 배수
				continue;     //반복문 처음으로 이동
			

		System.out.println("i: " + (i+1));
		hap += (i+1);
		if((i+1) == 5) {
			System.out.println("탈출");
			break;
		}
		
	}
		System.out.println("1~10까지 3의배수를 제외한 합 :" + hap);
	}}
