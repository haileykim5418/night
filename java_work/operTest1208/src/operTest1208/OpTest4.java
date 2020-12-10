package operTest1208;

public class OpTest4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int num = 99;
		//&& (논리 and연산자)
		//true && true --> true
		//true && false --> false
		//false && true --> false
		//false && false --> false
		System.out.println("and연산 : " +
			((num >= 100) && (num <= 200)));
		
		//true || true --> true
		//true || false --> true
		//false || true --> true
		//false || false --> false
		System.out.println("and연산 : " +
				((num >= 100) || (num <= 200)));
		// ! (논리 not연산자)
		// ! (true) --> false
		// ! (false) --> true
		System.out.println("not연산자: " + !(num == 100));
		


		
	}

}
