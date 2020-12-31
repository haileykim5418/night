package method1230;

public class Method4 {

	public static void main(String[] args) {
		int num = 10;
		//매개변수로 10을 전달
		func(num);
	

	}

	public static void func(int num) {
		num = num + 1;
		System.out.println("num: " + num);
	}
}
