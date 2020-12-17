package loopTest1216;

public class Test2_1 {

	public static void main(String[] args) {
		System.out.println("----------------------------");
		System.out.println("5의 배수 출력 프로그램");
		System.out.println("----------------------------");
		int i = 0;
		while (i<100) {
			if ((i+1)%5 == 0) {
				System.out.println((i+1));
			}
			i++;
		}
	}

}
