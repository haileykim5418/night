package method1230;

public class Test7 {

	public static void main(String[] args) {
		sum(0);
		sum1(0);
		System.out.println("홀수 : " + sum1(0)+"짝수 : "+ sum(0));
	
	}
	

	public static int sum(int a) {
		int zzak = 0;
		for (int i = 1; i <= 100; i++) {
			if (i % 2 == 0) {
				zzak+=i;	
			}
		}
		return zzak;
	}
	
	public static int sum1(int a) {
		int hol = 0;
	for (int i = 1; i <= 100; i++) {
		if (i % 2 == 1) {
			hol+=i;	
		}
	}
	return hol;
}
		
	}

