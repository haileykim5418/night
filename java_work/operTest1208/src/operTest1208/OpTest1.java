package operTest1208;

public class OpTest1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int num1 = 2, num2 = 3;
		int num3 = 4;
		//연산자 우선순위
		//() > *,/ > +,-
		int result = num1 + num2 - num3;
		System.out.println("result: " + result);
		
		int result2 = num1 + (num2 - num3);
		System.out.println("Result2 : " + result2);
		
		result = num1 + num2 * num3;
		System.out.println("result: " + result);
		
		result = (num1 + num2) * num3;
		System.out.println("result: " + result);
		
		result = num1 * num2 / num3;
		System.out.println("result: " + result);
		
		result = num3 % num2;
		System.out.println("result: " + result);


	}
	

}
