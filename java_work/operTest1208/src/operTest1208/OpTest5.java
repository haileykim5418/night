package operTest1208;

public class OpTest5 {

	public static void main(String[] args) {
		//3항 연산자
		//메소드 안에서 선언된 변수의 초기값이 없으면 쓰레기값이 들어감
		int num1 = 10;
		int num2 = 15;
		String str = "";
		str = (++num1 >= num2) ? "num이 크다" : "num2가 크다";
		System.out.println(str);
	
 }}