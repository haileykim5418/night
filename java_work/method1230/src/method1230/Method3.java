package method1230;

public class Method3 {
	static int num=200; //전역변수
	
	public static void func() {
		int num = 100; //지역변수
		System.out.println("num: " +num);
	}
	public static void main(String[] args) {
		System.out.println("num" + num);
		

	}

}
