package method1230;

public class Test3 {

	public static void main(String[] args) {
	int arr [] = new int [10];
	for (int i = 0; i < arr.length; i++) {
		arr[i] = (int) (Math.random() * 100 + 1);
	}
	func(arr);
	}

	public static void func(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			if(arr[i]%2==0) {
				System.out.println(arr[i] + " : 짝수");
			}else {
				System.out.println(arr[i] + " : 홀수");
			}
		}
	}
}

