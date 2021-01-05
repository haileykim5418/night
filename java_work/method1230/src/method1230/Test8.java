package method1230;

public class Test8 {

	public static void main(String[] args) {
		gugu();
		
		
	}
	public static void gugu() {
		
		for(int j=1; j<=9; j++) {
			
				for(int i=2; i<=9;i++) {
					if(i%2!= 0) {
					System.out.printf(i+"x"+j+"="+(i*j)+"\t");
			}
			
			}
			System.out.println();
		}
	}
}
