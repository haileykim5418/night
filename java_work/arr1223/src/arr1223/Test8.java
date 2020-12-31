package arr1223;

public class Test8 {

	public static void main(String[] args) {
		System.out.println("-------------------");
		System.out.println("간단한 로또 프로그램");
		System.out.println("-------------------");
		int arr[] = new int[6];
		for (int i = 0; i < 6; i++) {
			int lotto = (int) (Math.random() * 45) + 1;

			if (i == 0) {
				arr[i] = lotto;
			} 
			else {
				arr[i]=lotto;
				for(int j=0;j<i;j++) {
					if(arr[j] == arr[i]) {
						i--;
						break;
					}
				}
			}
		}
		for (int i = 0; i < 6; i++) {
			System.out.print(arr[i]+"\t");
		}

	}

}
