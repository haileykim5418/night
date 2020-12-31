package arr1223;

public class Test5 {

	public static void main(String[] args) {

		int arr[][] = new int[3][3];
		int arr2[][] = new int[3][3];
		int num = 1;
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j] = num++;
				System.out.print(arr[i][j] + "\t");
			}
			System.out.println();
		}
		num = 1;
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				arr2[i][j] = (num++)*10;
				System.out.print(arr2[i][j]+"\t");
			}
			System.out.println();
		}
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
			
				System.out.print(arr[i][j]+arr2[i][j]+"\t");
			}
			System.out.println();
		}
	}

}
