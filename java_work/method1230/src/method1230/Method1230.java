package method1230;

public class Method1230 {

	public static void func2(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				System.out.println(arr[i][j] + " ");
			}
			System.out.println();
		}

	}

	public static void main(String[] args) {
		System.out.println("1차원배열");
	}int arr[] =  {1,2,3,4,5};

	func(arr);	

	System.out.println("\n2차원 배열");
		int arr2[][]={

				{1,2,3},
		{4,5,6}};
		func2(arr2);