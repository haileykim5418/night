package test1222;

public class Test5 {

	public static void main(String[] args) {
		System.out.println("--------------------");
		System.out.println("구구단 프로그램");
		System.out.println("--------------------");
		for(int i=1; i<=9; i++) {
			for(int j=2; j<=9; j++) {
				System.out.print(i+"x"+j+"="+(i*j)+" \t");					
			}
			System.out.print("\n");
		}

	}

}
