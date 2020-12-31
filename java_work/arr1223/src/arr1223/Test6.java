package arr1223;

public class Test6 {

	public static void main(String[] args) {
		int arr[][]=new int [9][9];
		
		for(int j=1; j<=9; j++) {
			for(int i=2; i<=9; i++) {
				int value = i*j;
				System.out.print(i+"x"+j+"="+value+"\t");
			}
			System.out.println();
		}
	}

}
